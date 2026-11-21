using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001184 RID: 4484
	[NetMessage(EMessageId.SceneBlockSplitSwitchStatePush)]
	public sealed class SceneBlockSplitSwitchStatePush : IMessage<SceneBlockSplitSwitchStatePush>, IMessage, IEquatable<SceneBlockSplitSwitchStatePush>, IDeepCloneable<SceneBlockSplitSwitchStatePush>, IBufferMessage
	{
		// Token: 0x06017F29 RID: 98089 RVA: 0x0037C19B File Offset: 0x0037A39B
		[NullableContext(1)]
		public static SceneBlockSplitSwitchStatePush Create()
		{
			return new SceneBlockSplitSwitchStatePush();
		}

		// Token: 0x1700509A RID: 20634
		// (get) Token: 0x06017F2A RID: 98090 RVA: 0x0037C1A2 File Offset: 0x0037A3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700509B RID: 20635
		// (get) Token: 0x06017F2B RID: 98091 RVA: 0x0037C1A5 File Offset: 0x0037A3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitSwitchStatePush.Descriptor;
			}
		}

		// Token: 0x06017F2C RID: 98092 RVA: 0x0037C1AC File Offset: 0x0037A3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitSwitchStatePush()
		{
		}

		// Token: 0x06017F2D RID: 98093 RVA: 0x0037C1B4 File Offset: 0x0037A3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitSwitchStatePush(SceneBlockSplitSwitchStatePush other) : this()
		{
			this.switchState_ = other.switchState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F2E RID: 98094 RVA: 0x0037C1D9 File Offset: 0x0037A3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitSwitchStatePush Clone()
		{
			return new SceneBlockSplitSwitchStatePush(this);
		}

		// Token: 0x1700509C RID: 20636
		// (get) Token: 0x06017F2F RID: 98095 RVA: 0x0037C1E1 File Offset: 0x0037A3E1
		// (set) Token: 0x06017F30 RID: 98096 RVA: 0x0037C1E9 File Offset: 0x0037A3E9
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

		// Token: 0x06017F31 RID: 98097 RVA: 0x0037C1F2 File Offset: 0x0037A3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitSwitchStatePush);
		}

		// Token: 0x06017F32 RID: 98098 RVA: 0x0037C200 File Offset: 0x0037A400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitSwitchStatePush other)
		{
			return other != null && (other == this || (this.SwitchState == other.SwitchState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F33 RID: 98099 RVA: 0x0037C230 File Offset: 0x0037A430
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

		// Token: 0x06017F34 RID: 98100 RVA: 0x0037C275 File Offset: 0x0037A475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F35 RID: 98101 RVA: 0x0037C282 File Offset: 0x0037A482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F36 RID: 98102 RVA: 0x0037C28B File Offset: 0x0037A48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.SwitchState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F37 RID: 98103 RVA: 0x0037C2C0 File Offset: 0x0037A4C0
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

		// Token: 0x06017F38 RID: 98104 RVA: 0x0037C2FE File Offset: 0x0037A4FE
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

		// Token: 0x06017F39 RID: 98105 RVA: 0x0037C32F File Offset: 0x0037A52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F3A RID: 98106 RVA: 0x0037C338 File Offset: 0x0037A538
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SwitchState = (ESceneBlockSwithState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008EA8 RID: 36520
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EA9 RID: 36521
		public const int SwitchStateFieldNumber = 7;

		// Token: 0x04008EAA RID: 36522
		private ESceneBlockSwithState switchState_;
	}
}
