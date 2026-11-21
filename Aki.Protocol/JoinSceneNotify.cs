using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000852 RID: 2130
	[NetMessage(EMessageId.JoinSceneNotify)]
	public sealed class JoinSceneNotify : IMessage<JoinSceneNotify>, IMessage, IEquatable<JoinSceneNotify>, IDeepCloneable<JoinSceneNotify>, IBufferMessage
	{
		// Token: 0x0600BE37 RID: 48695 RVA: 0x001C44DC File Offset: 0x001C26DC
		[NullableContext(1)]
		public static JoinSceneNotify Create()
		{
			return new JoinSceneNotify();
		}

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x0600BE38 RID: 48696 RVA: 0x001C44E3 File Offset: 0x001C26E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x0600BE39 RID: 48697 RVA: 0x001C44E6 File Offset: 0x001C26E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinSceneNotify.Descriptor;
			}
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x001C44ED File Offset: 0x001C26ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotify()
		{
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x001C44F8 File Offset: 0x001C26F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotify(JoinSceneNotify other) : this()
		{
			this.sceneInfo_ = ((other.sceneInfo_ != null) ? other.sceneInfo_.Clone() : null);
			this.maxEntityId_ = other.maxEntityId_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE3C RID: 48700 RVA: 0x001C4560 File Offset: 0x001C2760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotify Clone()
		{
			return new JoinSceneNotify(this);
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x0600BE3D RID: 48701 RVA: 0x001C4568 File Offset: 0x001C2768
		// (set) Token: 0x0600BE3E RID: 48702 RVA: 0x001C4570 File Offset: 0x001C2770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInformation SceneInfo
		{
			get
			{
				return this.sceneInfo_;
			}
			set
			{
				this.sceneInfo_ = value;
			}
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x0600BE3F RID: 48703 RVA: 0x001C4579 File Offset: 0x001C2779
		// (set) Token: 0x0600BE40 RID: 48704 RVA: 0x001C4581 File Offset: 0x001C2781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MaxEntityId
		{
			get
			{
				return this.maxEntityId_;
			}
			set
			{
				this.maxEntityId_ = value;
			}
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x0600BE41 RID: 48705 RVA: 0x001C458A File Offset: 0x001C278A
		// (set) Token: 0x0600BE42 RID: 48706 RVA: 0x001C4592 File Offset: 0x001C2792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionOptionPb TransitionOption
		{
			get
			{
				return this.transitionOption_;
			}
			set
			{
				this.transitionOption_ = value;
			}
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x001C459B File Offset: 0x001C279B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinSceneNotify);
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x001C45AC File Offset: 0x001C27AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinSceneNotify other)
		{
			return other != null && (other == this || (object.Equals(this.SceneInfo, other.SceneInfo) && this.MaxEntityId == other.MaxEntityId && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x001C4610 File Offset: 0x001C2810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.sceneInfo_ != null)
			{
				num ^= this.SceneInfo.GetHashCode();
			}
			if (this.MaxEntityId != 0L)
			{
				num ^= this.MaxEntityId.GetHashCode();
			}
			if (this.transitionOption_ != null)
			{
				num ^= this.TransitionOption.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE46 RID: 48710 RVA: 0x001C467B File Offset: 0x001C287B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x001C4688 File Offset: 0x001C2888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x001C4694 File Offset: 0x001C2894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.TransitionOption);
			}
			if (this.MaxEntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.MaxEntityId);
			}
			if (this.sceneInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SceneInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x001C470C File Offset: 0x001C290C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.sceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SceneInfo);
			}
			if (this.MaxEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MaxEntityId);
			}
			if (this.transitionOption_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x001C477C File Offset: 0x001C297C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JoinSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.sceneInfo_ != null)
			{
				if (this.sceneInfo_ == null)
				{
					this.SceneInfo = new SceneInformation();
				}
				this.SceneInfo.MergeFrom(other.SceneInfo);
			}
			if (other.MaxEntityId != 0L)
			{
				this.MaxEntityId = other.MaxEntityId;
			}
			if (other.transitionOption_ != null)
			{
				if (this.transitionOption_ == null)
				{
					this.TransitionOption = new TransitionOptionPb();
				}
				this.TransitionOption.MergeFrom(other.TransitionOption);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x001C4810 File Offset: 0x001C2A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE4C RID: 48716 RVA: 0x001C481C File Offset: 0x001C2A1C
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
				if (num != 26U)
				{
					if (num != 48U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.sceneInfo_ == null)
							{
								this.SceneInfo = new SceneInformation();
							}
							input.ReadMessage(this.SceneInfo);
						}
					}
					else
					{
						this.MaxEntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.transitionOption_ == null)
					{
						this.TransitionOption = new TransitionOptionPb();
					}
					input.ReadMessage(this.TransitionOption);
				}
			}
		}

		// Token: 0x04005356 RID: 21334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005357 RID: 21335
		public const int SceneInfoFieldNumber = 11;

		// Token: 0x04005358 RID: 21336
		private SceneInformation sceneInfo_;

		// Token: 0x04005359 RID: 21337
		public const int MaxEntityIdFieldNumber = 6;

		// Token: 0x0400535A RID: 21338
		private long maxEntityId_;

		// Token: 0x0400535B RID: 21339
		public const int TransitionOptionFieldNumber = 3;

		// Token: 0x0400535C RID: 21340
		private TransitionOptionPb transitionOption_;
	}
}
