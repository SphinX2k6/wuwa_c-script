using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001458 RID: 5208
	[NetMessage(EMessageId.TrapDefenseTechUnlockRequest)]
	public sealed class TrapDefenseTechUnlockRequest : IMessage<TrapDefenseTechUnlockRequest>, IMessage, IEquatable<TrapDefenseTechUnlockRequest>, IDeepCloneable<TrapDefenseTechUnlockRequest>, IBufferMessage
	{
		// Token: 0x0601B944 RID: 112964 RVA: 0x003FE1A0 File Offset: 0x003FC3A0
		[NullableContext(1)]
		public static TrapDefenseTechUnlockRequest Create()
		{
			return new TrapDefenseTechUnlockRequest();
		}

		// Token: 0x17005D00 RID: 23808
		// (get) Token: 0x0601B945 RID: 112965 RVA: 0x003FE1A7 File Offset: 0x003FC3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D01 RID: 23809
		// (get) Token: 0x0601B946 RID: 112966 RVA: 0x003FE1AA File Offset: 0x003FC3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechUnlockRequest.Descriptor;
			}
		}

		// Token: 0x0601B947 RID: 112967 RVA: 0x003FE1B1 File Offset: 0x003FC3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockRequest()
		{
		}

		// Token: 0x0601B948 RID: 112968 RVA: 0x003FE1B9 File Offset: 0x003FC3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockRequest(TrapDefenseTechUnlockRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B949 RID: 112969 RVA: 0x003FE1DE File Offset: 0x003FC3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechUnlockRequest Clone()
		{
			return new TrapDefenseTechUnlockRequest(this);
		}

		// Token: 0x17005D02 RID: 23810
		// (get) Token: 0x0601B94A RID: 112970 RVA: 0x003FE1E6 File Offset: 0x003FC3E6
		// (set) Token: 0x0601B94B RID: 112971 RVA: 0x003FE1EE File Offset: 0x003FC3EE
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

		// Token: 0x0601B94C RID: 112972 RVA: 0x003FE1F7 File Offset: 0x003FC3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechUnlockRequest);
		}

		// Token: 0x0601B94D RID: 112973 RVA: 0x003FE205 File Offset: 0x003FC405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechUnlockRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B94E RID: 112974 RVA: 0x003FE234 File Offset: 0x003FC434
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

		// Token: 0x0601B94F RID: 112975 RVA: 0x003FE273 File Offset: 0x003FC473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B950 RID: 112976 RVA: 0x003FE280 File Offset: 0x003FC480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B951 RID: 112977 RVA: 0x003FE289 File Offset: 0x003FC489
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

		// Token: 0x0601B952 RID: 112978 RVA: 0x003FE2BC File Offset: 0x003FC4BC
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

		// Token: 0x0601B953 RID: 112979 RVA: 0x003FE2FA File Offset: 0x003FC4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechUnlockRequest other)
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

		// Token: 0x0601B954 RID: 112980 RVA: 0x003FE32B File Offset: 0x003FC52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B955 RID: 112981 RVA: 0x003FE334 File Offset: 0x003FC534
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

		// Token: 0x04009EFF RID: 40703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F00 RID: 40704
		public const int IdFieldNumber = 8;

		// Token: 0x04009F01 RID: 40705
		private int id_;
	}
}
