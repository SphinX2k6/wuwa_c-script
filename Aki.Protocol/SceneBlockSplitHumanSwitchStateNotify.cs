using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001181 RID: 4481
	[NetMessage(EMessageId.SceneBlockSplitHumanSwitchStateNotify)]
	public sealed class SceneBlockSplitHumanSwitchStateNotify : IMessage<SceneBlockSplitHumanSwitchStateNotify>, IMessage, IEquatable<SceneBlockSplitHumanSwitchStateNotify>, IDeepCloneable<SceneBlockSplitHumanSwitchStateNotify>, IBufferMessage
	{
		// Token: 0x06017EED RID: 98029 RVA: 0x0037B9D0 File Offset: 0x00379BD0
		[NullableContext(1)]
		public static SceneBlockSplitHumanSwitchStateNotify Create()
		{
			return new SceneBlockSplitHumanSwitchStateNotify();
		}

		// Token: 0x1700508E RID: 20622
		// (get) Token: 0x06017EEE RID: 98030 RVA: 0x0037B9D7 File Offset: 0x00379BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700508F RID: 20623
		// (get) Token: 0x06017EEF RID: 98031 RVA: 0x0037B9DA File Offset: 0x00379BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneBlockSplitHumanSwitchStateNotify.Descriptor;
			}
		}

		// Token: 0x06017EF0 RID: 98032 RVA: 0x0037B9E1 File Offset: 0x00379BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanSwitchStateNotify()
		{
		}

		// Token: 0x06017EF1 RID: 98033 RVA: 0x0037B9E9 File Offset: 0x00379BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanSwitchStateNotify(SceneBlockSplitHumanSwitchStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.switchState_ = other.switchState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017EF2 RID: 98034 RVA: 0x0037BA1A File Offset: 0x00379C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBlockSplitHumanSwitchStateNotify Clone()
		{
			return new SceneBlockSplitHumanSwitchStateNotify(this);
		}

		// Token: 0x17005090 RID: 20624
		// (get) Token: 0x06017EF3 RID: 98035 RVA: 0x0037BA22 File Offset: 0x00379C22
		// (set) Token: 0x06017EF4 RID: 98036 RVA: 0x0037BA2A File Offset: 0x00379C2A
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

		// Token: 0x17005091 RID: 20625
		// (get) Token: 0x06017EF5 RID: 98037 RVA: 0x0037BA33 File Offset: 0x00379C33
		// (set) Token: 0x06017EF6 RID: 98038 RVA: 0x0037BA3B File Offset: 0x00379C3B
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

		// Token: 0x06017EF7 RID: 98039 RVA: 0x0037BA44 File Offset: 0x00379C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneBlockSplitHumanSwitchStateNotify);
		}

		// Token: 0x06017EF8 RID: 98040 RVA: 0x0037BA52 File Offset: 0x00379C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneBlockSplitHumanSwitchStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.SwitchState == other.SwitchState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017EF9 RID: 98041 RVA: 0x0037BA90 File Offset: 0x00379C90
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

		// Token: 0x06017EFA RID: 98042 RVA: 0x0037BAEE File Offset: 0x00379CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017EFB RID: 98043 RVA: 0x0037BAFB File Offset: 0x00379CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017EFC RID: 98044 RVA: 0x0037BB04 File Offset: 0x00379D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SwitchState != ESceneBlockSwithState.BstateAll)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.SwitchState);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017EFD RID: 98045 RVA: 0x0037BB60 File Offset: 0x00379D60
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

		// Token: 0x06017EFE RID: 98046 RVA: 0x0037BBB8 File Offset: 0x00379DB8
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

		// Token: 0x06017EFF RID: 98047 RVA: 0x0037BC08 File Offset: 0x00379E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F00 RID: 98048 RVA: 0x0037BC14 File Offset: 0x00379E14
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
					if (num != 112U)
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

		// Token: 0x04008E98 RID: 36504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E99 RID: 36505
		public const int PlayerIdFieldNumber = 14;

		// Token: 0x04008E9A RID: 36506
		private int playerId_;

		// Token: 0x04008E9B RID: 36507
		public const int SwitchStateFieldNumber = 8;

		// Token: 0x04008E9C RID: 36508
		private ESceneBlockSwithState switchState_;
	}
}
