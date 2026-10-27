using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000421 RID: 1057
	[NetMessage(EMessageId.EdgeRunnerFunctionPreUnlockRequest)]
	public sealed class EdgeRunnerFunctionPreUnlockRequest : IMessage<EdgeRunnerFunctionPreUnlockRequest>, IMessage, IEquatable<EdgeRunnerFunctionPreUnlockRequest>, IDeepCloneable<EdgeRunnerFunctionPreUnlockRequest>, IBufferMessage
	{
		// Token: 0x060065A7 RID: 26023 RVA: 0x000F4BE6 File Offset: 0x000F2DE6
		[NullableContext(1)]
		public static EdgeRunnerFunctionPreUnlockRequest Create()
		{
			return new EdgeRunnerFunctionPreUnlockRequest();
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x060065A8 RID: 26024 RVA: 0x000F4BED File Offset: 0x000F2DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x060065A9 RID: 26025 RVA: 0x000F4BF0 File Offset: 0x000F2DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerFunctionPreUnlockRequest.Descriptor;
			}
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x000F4BF7 File Offset: 0x000F2DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockRequest()
		{
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x000F4BFF File Offset: 0x000F2DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockRequest(EdgeRunnerFunctionPreUnlockRequest other) : this()
		{
			this.funcId_ = other.funcId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x000F4C24 File Offset: 0x000F2E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerFunctionPreUnlockRequest Clone()
		{
			return new EdgeRunnerFunctionPreUnlockRequest(this);
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x000F4C2C File Offset: 0x000F2E2C
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x000F4C34 File Offset: 0x000F2E34
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

		// Token: 0x060065AF RID: 26031 RVA: 0x000F4C3D File Offset: 0x000F2E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerFunctionPreUnlockRequest);
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x000F4C4B File Offset: 0x000F2E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerFunctionPreUnlockRequest other)
		{
			return other != null && (other == this || (this.FuncId == other.FuncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x000F4C7C File Offset: 0x000F2E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FuncId != 0)
			{
				num ^= this.FuncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x000F4CBB File Offset: 0x000F2EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x000F4CC8 File Offset: 0x000F2EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x000F4CD1 File Offset: 0x000F2ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FuncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FuncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x000F4D04 File Offset: 0x000F2F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FuncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x000F4D42 File Offset: 0x000F2F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerFunctionPreUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FuncId != 0)
			{
				this.FuncId = other.FuncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x000F4D73 File Offset: 0x000F2F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x000F4D7C File Offset: 0x000F2F7C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FuncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040038F0 RID: 14576
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038F1 RID: 14577
		public const int FuncIdFieldNumber = 4;

		// Token: 0x040038F2 RID: 14578
		private int funcId_;
	}
}
