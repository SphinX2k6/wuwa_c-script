using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128E RID: 4750
	[NetMessage(EMessageId.SlashAndTowerSaveRecordRequest)]
	public sealed class SlashAndTowerSaveRecordRequest : IMessage<SlashAndTowerSaveRecordRequest>, IMessage, IEquatable<SlashAndTowerSaveRecordRequest>, IDeepCloneable<SlashAndTowerSaveRecordRequest>, IBufferMessage
	{
		// Token: 0x060195A7 RID: 103847 RVA: 0x003B2968 File Offset: 0x003B0B68
		[NullableContext(1)]
		public static SlashAndTowerSaveRecordRequest Create()
		{
			return new SlashAndTowerSaveRecordRequest();
		}

		// Token: 0x170055C0 RID: 21952
		// (get) Token: 0x060195A8 RID: 103848 RVA: 0x003B296F File Offset: 0x003B0B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055C1 RID: 21953
		// (get) Token: 0x060195A9 RID: 103849 RVA: 0x003B2972 File Offset: 0x003B0B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerSaveRecordRequest.Descriptor;
			}
		}

		// Token: 0x060195AA RID: 103850 RVA: 0x003B2979 File Offset: 0x003B0B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordRequest()
		{
		}

		// Token: 0x060195AB RID: 103851 RVA: 0x003B2981 File Offset: 0x003B0B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordRequest(SlashAndTowerSaveRecordRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060195AC RID: 103852 RVA: 0x003B29A6 File Offset: 0x003B0BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordRequest Clone()
		{
			return new SlashAndTowerSaveRecordRequest(this);
		}

		// Token: 0x170055C2 RID: 21954
		// (get) Token: 0x060195AD RID: 103853 RVA: 0x003B29AE File Offset: 0x003B0BAE
		// (set) Token: 0x060195AE RID: 103854 RVA: 0x003B29B6 File Offset: 0x003B0BB6
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

		// Token: 0x060195AF RID: 103855 RVA: 0x003B29BF File Offset: 0x003B0BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerSaveRecordRequest);
		}

		// Token: 0x060195B0 RID: 103856 RVA: 0x003B29CD File Offset: 0x003B0BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerSaveRecordRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060195B1 RID: 103857 RVA: 0x003B29FC File Offset: 0x003B0BFC
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

		// Token: 0x060195B2 RID: 103858 RVA: 0x003B2A3B File Offset: 0x003B0C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195B3 RID: 103859 RVA: 0x003B2A48 File Offset: 0x003B0C48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195B4 RID: 103860 RVA: 0x003B2A51 File Offset: 0x003B0C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195B5 RID: 103861 RVA: 0x003B2A84 File Offset: 0x003B0C84
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

		// Token: 0x060195B6 RID: 103862 RVA: 0x003B2AC2 File Offset: 0x003B0CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerSaveRecordRequest other)
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

		// Token: 0x060195B7 RID: 103863 RVA: 0x003B2AF3 File Offset: 0x003B0CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195B8 RID: 103864 RVA: 0x003B2AFC File Offset: 0x003B0CFC
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095F5 RID: 38389
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095F6 RID: 38390
		public const int IdFieldNumber = 10;

		// Token: 0x040095F7 RID: 38391
		private int id_;
	}
}
