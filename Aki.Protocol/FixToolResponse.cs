using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000592 RID: 1426
	[NetMessage(EMessageId.FixToolResponse)]
	public sealed class FixToolResponse : IMessage<FixToolResponse>, IMessage, IEquatable<FixToolResponse>, IDeepCloneable<FixToolResponse>, IBufferMessage
	{
		// Token: 0x0600841E RID: 33822 RVA: 0x0013DE5C File Offset: 0x0013C05C
		[NullableContext(1)]
		public static FixToolResponse Create()
		{
			return new FixToolResponse();
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600841F RID: 33823 RVA: 0x0013DE63 File Offset: 0x0013C063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06008420 RID: 33824 RVA: 0x0013DE66 File Offset: 0x0013C066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FixToolResponse.Descriptor;
			}
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x0013DE6D File Offset: 0x0013C06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolResponse()
		{
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x0013DE75 File Offset: 0x0013C075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolResponse(FixToolResponse other) : this()
		{
			this.code_ = other.code_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x0013DEA6 File Offset: 0x0013C0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FixToolResponse Clone()
		{
			return new FixToolResponse(this);
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06008424 RID: 33828 RVA: 0x0013DEAE File Offset: 0x0013C0AE
		// (set) Token: 0x06008425 RID: 33829 RVA: 0x0013DEB6 File Offset: 0x0013C0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06008426 RID: 33830 RVA: 0x0013DEBF File Offset: 0x0013C0BF
		// (set) Token: 0x06008427 RID: 33831 RVA: 0x0013DEC7 File Offset: 0x0013C0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0013DED0 File Offset: 0x0013C0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FixToolResponse);
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x0013DEDE File Offset: 0x0013C0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FixToolResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x0013DF1C File Offset: 0x0013C11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x0013DF7A File Offset: 0x0013C17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x0013DF87 File Offset: 0x0013C187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x0013DF90 File Offset: 0x0013C190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x0013DFEC File Offset: 0x0013C1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x0013E044 File Offset: 0x0013C244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FixToolResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x0013E094 File Offset: 0x0013C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x0013E0A0 File Offset: 0x0013C2A0
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400419C RID: 16796
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400419D RID: 16797
		public const int CodeFieldNumber = 12;

		// Token: 0x0400419E RID: 16798
		private ErrorCode code_;

		// Token: 0x0400419F RID: 16799
		public const int EntityIdFieldNumber = 10;

		// Token: 0x040041A0 RID: 16800
		private long entityId_;
	}
}
