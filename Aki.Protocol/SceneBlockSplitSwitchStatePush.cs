using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114A RID: 4426
	[NetMessage(EMessageId.SceneBlockSplitSwitchStatePush)]
	public sealed class SceneBlockSplitSwitchStatePush : IMessage<SceneBlockSplitSwitchStatePush>, IMessage, IEquatable<SceneBlockSplitSwitchStatePush>, IDeepCloneable<SceneBlockSplitSwitchStatePush>, IBufferMessage
	{
		// Token: 0x06017988 RID: 96648 RVA: 0x0036CE4F File Offset: 0x0036B04F
		[NullableContext(1)]
		public static SceneBlockSplitSwitchStatePush Create()
		{
			return new SceneBlockSplitSwitchStatePush();
		}

		// Token: 0x17004F2E RID: 20270
		// (get) Token: 0x06017989 RID: 96649 RVA: 0x0036CE56 File Offset: 0x0036B056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x0601798A RID: 96650 RVA: 0x0036CE59 File Offset: 0x0036B059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitSwitchStatePush.Descriptor;
			}
		}

		// Token: 0x0601798B RID: 96651 RVA: 0x0036CE60 File Offset: 0x0036B060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitSwitchStatePush()
		{
		}

		// Token: 0x0601798C RID: 96652 RVA: 0x0036CE68 File Offset: 0x0036B068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitSwitchStatePush(SceneBlockSplitSwitchStatePush other) : this()
		{
			this.switchState_ = other.switchState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601798D RID: 96653 RVA: 0x0036CE8D File Offset: 0x0036B08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitSwitchStatePush Clone()
		{
			return new SceneBlockSplitSwitchStatePush(this);
		}

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x0601798E RID: 96654 RVA: 0x0036CE95 File Offset: 0x0036B095
		// (set) Token: 0x0601798F RID: 96655 RVA: 0x0036CE9D File Offset: 0x0036B09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ESceneBlockSwithState SwitchState
		{
			get
			{
				return this.switchState_;
			}
			set
			{
				this.switchState_ = value;
			}
		}

		// Token: 0x06017990 RID: 96656 RVA: 0x0036CEA6 File Offset: 0x0036B0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitSwitchStatePush);
		}

		// Token: 0x06017991 RID: 96657 RVA: 0x0036CEB4 File Offset: 0x0036B0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitSwitchStatePush other)
		{
			return other != null && (other == this || (this.SwitchState == other.SwitchState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017992 RID: 96658 RVA: 0x0036CEE4 File Offset: 0x0036B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				num ^= this.SwitchState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017993 RID: 96659 RVA: 0x0036CF29 File Offset: 0x0036B129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017994 RID: 96660 RVA: 0x0036CF36 File Offset: 0x0036B136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017995 RID: 96661 RVA: 0x0036CF3F File Offset: 0x0036B13F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.SwitchState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017996 RID: 96662 RVA: 0x0036CF74 File Offset: 0x0036B174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SwitchState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017997 RID: 96663 RVA: 0x0036CFB2 File Offset: 0x0036B1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitSwitchStatePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				this.SwitchState = other.SwitchState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017998 RID: 96664 RVA: 0x0036CFE3 File Offset: 0x0036B1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017999 RID: 96665 RVA: 0x0036CFEC File Offset: 0x0036B1EC
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SwitchState = (ESceneBlockSwithState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008C15 RID: 35861
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C16 RID: 35862
		public const int SwitchStateFieldNumber = 11;

		// Token: 0x04008C17 RID: 35863
		private ESceneBlockSwithState switchState_;
	}
}
