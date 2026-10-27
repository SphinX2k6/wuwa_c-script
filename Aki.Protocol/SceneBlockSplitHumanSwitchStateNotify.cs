using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001147 RID: 4423
	[NetMessage(EMessageId.SceneBlockSplitHumanSwitchStateNotify)]
	public sealed class SceneBlockSplitHumanSwitchStateNotify : IMessage<SceneBlockSplitHumanSwitchStateNotify>, IMessage, IEquatable<SceneBlockSplitHumanSwitchStateNotify>, IDeepCloneable<SceneBlockSplitHumanSwitchStateNotify>, IBufferMessage
	{
		// Token: 0x0601794C RID: 96588 RVA: 0x0036C688 File Offset: 0x0036A888
		[NullableContext(1)]
		public static SceneBlockSplitHumanSwitchStateNotify Create()
		{
			return new SceneBlockSplitHumanSwitchStateNotify();
		}

		// Token: 0x17004F22 RID: 20258
		// (get) Token: 0x0601794D RID: 96589 RVA: 0x0036C68F File Offset: 0x0036A88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F23 RID: 20259
		// (get) Token: 0x0601794E RID: 96590 RVA: 0x0036C692 File Offset: 0x0036A892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitHumanSwitchStateNotify.Descriptor;
			}
		}

		// Token: 0x0601794F RID: 96591 RVA: 0x0036C699 File Offset: 0x0036A899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanSwitchStateNotify()
		{
		}

		// Token: 0x06017950 RID: 96592 RVA: 0x0036C6A1 File Offset: 0x0036A8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanSwitchStateNotify(SceneBlockSplitHumanSwitchStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.switchState_ = other.switchState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017951 RID: 96593 RVA: 0x0036C6D2 File Offset: 0x0036A8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanSwitchStateNotify Clone()
		{
			return new SceneBlockSplitHumanSwitchStateNotify(this);
		}

		// Token: 0x17004F24 RID: 20260
		// (get) Token: 0x06017952 RID: 96594 RVA: 0x0036C6DA File Offset: 0x0036A8DA
		// (set) Token: 0x06017953 RID: 96595 RVA: 0x0036C6E2 File Offset: 0x0036A8E2
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

		// Token: 0x17004F25 RID: 20261
		// (get) Token: 0x06017954 RID: 96596 RVA: 0x0036C6EB File Offset: 0x0036A8EB
		// (set) Token: 0x06017955 RID: 96597 RVA: 0x0036C6F3 File Offset: 0x0036A8F3
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

		// Token: 0x06017956 RID: 96598 RVA: 0x0036C6FC File Offset: 0x0036A8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitHumanSwitchStateNotify);
		}

		// Token: 0x06017957 RID: 96599 RVA: 0x0036C70A File Offset: 0x0036A90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitHumanSwitchStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.SwitchState == other.SwitchState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017958 RID: 96600 RVA: 0x0036C748 File Offset: 0x0036A948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
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

		// Token: 0x06017959 RID: 96601 RVA: 0x0036C7A6 File Offset: 0x0036A9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601795A RID: 96602 RVA: 0x0036C7B3 File Offset: 0x0036A9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601795B RID: 96603 RVA: 0x0036C7BC File Offset: 0x0036A9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.SwitchState);
			}
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

		// Token: 0x0601795C RID: 96604 RVA: 0x0036C814 File Offset: 0x0036AA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
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

		// Token: 0x0601795D RID: 96605 RVA: 0x0036C86C File Offset: 0x0036AA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneBlockSplitHumanSwitchStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				this.SwitchState = other.SwitchState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601795E RID: 96606 RVA: 0x0036C8BC File Offset: 0x0036AABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601795F RID: 96607 RVA: 0x0036C8C8 File Offset: 0x0036AAC8
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.SwitchState = (ESceneBlockSwithState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008C05 RID: 35845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C06 RID: 35846
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04008C07 RID: 35847
		private int playerId_;

		// Token: 0x04008C08 RID: 35848
		public const int SwitchStateFieldNumber = 1;

		// Token: 0x04008C09 RID: 35849
		private ESceneBlockSwithState switchState_;
	}
}
