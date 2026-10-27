using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000638 RID: 1592
	[NetMessage(EMessageId.FoundationCoreOperateRequest)]
	public sealed class FoundationCoreOperateRequest : IMessage<FoundationCoreOperateRequest>, IMessage, IEquatable<FoundationCoreOperateRequest>, IDeepCloneable<FoundationCoreOperateRequest>, IBufferMessage
	{
		// Token: 0x060092B5 RID: 37557 RVA: 0x00162F48 File Offset: 0x00161148
		[NullableContext(1)]
		public static FoundationCoreOperateRequest Create()
		{
			return new FoundationCoreOperateRequest();
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x060092B6 RID: 37558 RVA: 0x00162F4F File Offset: 0x0016114F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x060092B7 RID: 37559 RVA: 0x00162F52 File Offset: 0x00161152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationCoreOperateRequest.Descriptor;
			}
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x00162F59 File Offset: 0x00161159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateRequest()
		{
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x00162F61 File Offset: 0x00161161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateRequest(FoundationCoreOperateRequest other) : this()
		{
			this.foundationEntityIncId_ = other.foundationEntityIncId_;
			this.isTakeOut_ = other.isTakeOut_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x00162F92 File Offset: 0x00161192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreOperateRequest Clone()
		{
			return new FoundationCoreOperateRequest(this);
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x060092BB RID: 37563 RVA: 0x00162F9A File Offset: 0x0016119A
		// (set) Token: 0x060092BC RID: 37564 RVA: 0x00162FA2 File Offset: 0x001611A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FoundationEntityIncId
		{
			get
			{
				return this.foundationEntityIncId_;
			}
			set
			{
				this.foundationEntityIncId_ = value;
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x00162FAB File Offset: 0x001611AB
		// (set) Token: 0x060092BE RID: 37566 RVA: 0x00162FB3 File Offset: 0x001611B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTakeOut
		{
			get
			{
				return this.isTakeOut_;
			}
			set
			{
				this.isTakeOut_ = value;
			}
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x00162FBC File Offset: 0x001611BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationCoreOperateRequest);
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x00162FCA File Offset: 0x001611CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationCoreOperateRequest other)
		{
			return other != null && (other == this || (this.FoundationEntityIncId == other.FoundationEntityIncId && this.IsTakeOut == other.IsTakeOut && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x00163008 File Offset: 0x00161208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FoundationEntityIncId != 0L)
			{
				num ^= this.FoundationEntityIncId.GetHashCode();
			}
			if (this.IsTakeOut)
			{
				num ^= this.IsTakeOut.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x00163060 File Offset: 0x00161260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x0016306D File Offset: 0x0016126D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060092C4 RID: 37572 RVA: 0x00163078 File Offset: 0x00161278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsTakeOut)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsTakeOut);
			}
			if (this.FoundationEntityIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.FoundationEntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x001630D4 File Offset: 0x001612D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FoundationEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FoundationEntityIncId);
			}
			if (this.IsTakeOut)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x00163120 File Offset: 0x00161320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationCoreOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FoundationEntityIncId != 0L)
			{
				this.FoundationEntityIncId = other.FoundationEntityIncId;
			}
			if (other.IsTakeOut)
			{
				this.IsTakeOut = other.IsTakeOut;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x00163170 File Offset: 0x00161370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x0016317C File Offset: 0x0016137C
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
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FoundationEntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.IsTakeOut = input.ReadBool();
				}
			}
		}

		// Token: 0x040046B0 RID: 18096
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046B1 RID: 18097
		public const int FoundationEntityIncIdFieldNumber = 15;

		// Token: 0x040046B2 RID: 18098
		private long foundationEntityIncId_;

		// Token: 0x040046B3 RID: 18099
		public const int IsTakeOutFieldNumber = 7;

		// Token: 0x040046B4 RID: 18100
		private bool isTakeOut_;
	}
}
