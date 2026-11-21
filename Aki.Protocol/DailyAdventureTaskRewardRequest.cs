using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000327 RID: 807
	[NetMessage(EMessageId.DailyAdventureTaskRewardRequest)]
	public sealed class DailyAdventureTaskRewardRequest : IMessage<DailyAdventureTaskRewardRequest>, IMessage, IEquatable<DailyAdventureTaskRewardRequest>, IDeepCloneable<DailyAdventureTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600515F RID: 20831 RVA: 0x000C6899 File Offset: 0x000C4A99
		[NullableContext(1)]
		public static DailyAdventureTaskRewardRequest Create()
		{
			return new DailyAdventureTaskRewardRequest();
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x000C68A0 File Offset: 0x000C4AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x000C68A3 File Offset: 0x000C4AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x000C68AA File Offset: 0x000C4AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardRequest()
		{
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x000C68B2 File Offset: 0x000C4AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardRequest(DailyAdventureTaskRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x000C68D7 File Offset: 0x000C4AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardRequest Clone()
		{
			return new DailyAdventureTaskRewardRequest(this);
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06005165 RID: 20837 RVA: 0x000C68DF File Offset: 0x000C4ADF
		// (set) Token: 0x06005166 RID: 20838 RVA: 0x000C68E7 File Offset: 0x000C4AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x000C68F0 File Offset: 0x000C4AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureTaskRewardRequest);
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x000C68FE File Offset: 0x000C4AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureTaskRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x000C692C File Offset: 0x000C4B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x000C696B File Offset: 0x000C4B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x000C6978 File Offset: 0x000C4B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x000C6981 File Offset: 0x000C4B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x000C69B4 File Offset: 0x000C4BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x000C69F2 File Offset: 0x000C4BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventureTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x000C6A23 File Offset: 0x000C4C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x000C6A2C File Offset: 0x000C4C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003302 RID: 13058
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003303 RID: 13059
		public const int IdFieldNumber = 8;

		// Token: 0x04003304 RID: 13060
		private int id_;
	}
}
