using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BE RID: 190
	[NetMessage(EMessageId.AdventureManualDataRequest)]
	public sealed class AdventureManualDataRequest : IMessage<AdventureManualDataRequest>, IMessage, IEquatable<AdventureManualDataRequest>, IDeepCloneable<AdventureManualDataRequest>, IBufferMessage
	{
		// Token: 0x06001ECD RID: 7885 RVA: 0x00054100 File Offset: 0x00052300
		[NullableContext(1)]
		public static AdventureManualDataRequest Create()
		{
			return new AdventureManualDataRequest();
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00054107 File Offset: 0x00052307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0005410A File Offset: 0x0005230A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualDataRequest.Descriptor;
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00054111 File Offset: 0x00052311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataRequest()
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00054119 File Offset: 0x00052319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataRequest(AdventureManualDataRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0005413E File Offset: 0x0005233E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualDataRequest Clone()
		{
			return new AdventureManualDataRequest(this);
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00054146 File Offset: 0x00052346
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x0005414E File Offset: 0x0005234E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00054157 File Offset: 0x00052357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualDataRequest);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00054165 File Offset: 0x00052365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualDataRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00054194 File Offset: 0x00052394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000541D3 File Offset: 0x000523D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000541E0 File Offset: 0x000523E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000541E9 File Offset: 0x000523E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0005421C File Offset: 0x0005241C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0005425A File Offset: 0x0005245A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureManualDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0005428B File Offset: 0x0005248B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00054294 File Offset: 0x00052494
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040023CD RID: 9165
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023CE RID: 9166
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x040023CF RID: 9167
		private int playerId_;
	}
}
