using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000436 RID: 1078
	public sealed class EnableSystemFuncInfo : IMessage<EnableSystemFuncInfo>, IMessage, IEquatable<EnableSystemFuncInfo>, IDeepCloneable<EnableSystemFuncInfo>, IBufferMessage
	{
		// Token: 0x06006753 RID: 26451 RVA: 0x000F8370 File Offset: 0x000F6570
		[NullableContext(1)]
		public static EnableSystemFuncInfo Create()
		{
			return new EnableSystemFuncInfo();
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x000F8377 File Offset: 0x000F6577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnableSystemFuncInfo> Parser
		{
			get
			{
				return EnableSystemFuncInfo._parser;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06006755 RID: 26453 RVA: 0x000F837E File Offset: 0x000F657E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x000F8381 File Offset: 0x000F6581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableSystemFuncInfo.Descriptor;
			}
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x000F8388 File Offset: 0x000F6588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableSystemFuncInfo()
		{
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x000F8390 File Offset: 0x000F6590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableSystemFuncInfo(EnableSystemFuncInfo other) : this()
		{
			this.funcId_ = other.funcId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x000F83C1 File Offset: 0x000F65C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableSystemFuncInfo Clone()
		{
			return new EnableSystemFuncInfo(this);
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x000F83C9 File Offset: 0x000F65C9
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x000F83D1 File Offset: 0x000F65D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncId
		{
			get
			{
				return this.funcId_;
			}
			set
			{
				this.funcId_ = value;
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x000F83DA File Offset: 0x000F65DA
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x000F83E2 File Offset: 0x000F65E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x000F83EB File Offset: 0x000F65EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableSystemFuncInfo);
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x000F83F9 File Offset: 0x000F65F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableSystemFuncInfo other)
		{
			return other != null && (other == this || (this.FuncId == other.FuncId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x000F8438 File Offset: 0x000F6638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncId != 0)
			{
				num ^= this.FuncId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x000F8490 File Offset: 0x000F6690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x000F849D File Offset: 0x000F669D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006763 RID: 26467 RVA: 0x000F84A8 File Offset: 0x000F66A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FuncId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x000F8500 File Offset: 0x000F6700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x000F854C File Offset: 0x000F674C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableSystemFuncInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncId != 0)
			{
				this.FuncId = other.FuncId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x000F859C File Offset: 0x000F679C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006767 RID: 26471 RVA: 0x000F85A8 File Offset: 0x000F67A8
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.FuncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400395F RID: 14687
		private static readonly MessageParser<EnableSystemFuncInfo> _parser = new MessageParser<EnableSystemFuncInfo>(() => new EnableSystemFuncInfo());

		// Token: 0x04003960 RID: 14688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003961 RID: 14689
		public const int FuncIdFieldNumber = 1;

		// Token: 0x04003962 RID: 14690
		private int funcId_;

		// Token: 0x04003963 RID: 14691
		public const int IsOpenFieldNumber = 2;

		// Token: 0x04003964 RID: 14692
		private bool isOpen_;
	}
}
