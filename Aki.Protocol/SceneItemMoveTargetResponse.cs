using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A7 RID: 4519
	[NetMessage(EMessageId.SceneItemMoveTargetResponse)]
	public sealed class SceneItemMoveTargetResponse : IMessage<SceneItemMoveTargetResponse>, IMessage, IEquatable<SceneItemMoveTargetResponse>, IDeepCloneable<SceneItemMoveTargetResponse>, IBufferMessage
	{
		// Token: 0x0601822E RID: 98862 RVA: 0x00383C12 File Offset: 0x00381E12
		[NullableContext(1)]
		public static SceneItemMoveTargetResponse Create()
		{
			return new SceneItemMoveTargetResponse();
		}

		// Token: 0x17005153 RID: 20819
		// (get) Token: 0x0601822F RID: 98863 RVA: 0x00383C19 File Offset: 0x00381E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005154 RID: 20820
		// (get) Token: 0x06018230 RID: 98864 RVA: 0x00383C1C File Offset: 0x00381E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetResponse.Descriptor;
			}
		}

		// Token: 0x06018231 RID: 98865 RVA: 0x00383C23 File Offset: 0x00381E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetResponse()
		{
		}

		// Token: 0x06018232 RID: 98866 RVA: 0x00383C2B File Offset: 0x00381E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetResponse(SceneItemMoveTargetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018233 RID: 98867 RVA: 0x00383C50 File Offset: 0x00381E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetResponse Clone()
		{
			return new SceneItemMoveTargetResponse(this);
		}

		// Token: 0x17005155 RID: 20821
		// (get) Token: 0x06018234 RID: 98868 RVA: 0x00383C58 File Offset: 0x00381E58
		// (set) Token: 0x06018235 RID: 98869 RVA: 0x00383C60 File Offset: 0x00381E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06018236 RID: 98870 RVA: 0x00383C69 File Offset: 0x00381E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetResponse);
		}

		// Token: 0x06018237 RID: 98871 RVA: 0x00383C77 File Offset: 0x00381E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018238 RID: 98872 RVA: 0x00383CA8 File Offset: 0x00381EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018239 RID: 98873 RVA: 0x00383CED File Offset: 0x00381EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601823A RID: 98874 RVA: 0x00383CFA File Offset: 0x00381EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601823B RID: 98875 RVA: 0x00383D03 File Offset: 0x00381F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601823C RID: 98876 RVA: 0x00383D38 File Offset: 0x00381F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601823D RID: 98877 RVA: 0x00383D76 File Offset: 0x00381F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveTargetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601823E RID: 98878 RVA: 0x00383DA7 File Offset: 0x00381FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601823F RID: 98879 RVA: 0x00383DB0 File Offset: 0x00381FB0
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008FAF RID: 36783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FB0 RID: 36784
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04008FB1 RID: 36785
		private ErrorCode errorCode_;
	}
}
