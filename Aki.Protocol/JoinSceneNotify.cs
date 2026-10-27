using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000863 RID: 2147
	[NetMessage(EMessageId.JoinSceneNotify)]
	public sealed class JoinSceneNotify : IMessage<JoinSceneNotify>, IMessage, IEquatable<JoinSceneNotify>, IDeepCloneable<JoinSceneNotify>, IBufferMessage
	{
		// Token: 0x0600BF53 RID: 48979 RVA: 0x001C67C4 File Offset: 0x001C49C4
		[NullableContext(1)]
		public static JoinSceneNotify Create()
		{
			return new JoinSceneNotify();
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x0600BF54 RID: 48980 RVA: 0x001C67CB File Offset: 0x001C49CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x0600BF55 RID: 48981 RVA: 0x001C67CE File Offset: 0x001C49CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinSceneNotify.Descriptor;
			}
		}

		// Token: 0x0600BF56 RID: 48982 RVA: 0x001C67D5 File Offset: 0x001C49D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotify()
		{
		}

		// Token: 0x0600BF57 RID: 48983 RVA: 0x001C67E0 File Offset: 0x001C49E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotify(JoinSceneNotify other) : this()
		{
			this.sceneInfo_ = ((other.sceneInfo_ != null) ? other.sceneInfo_.Clone() : null);
			this.maxEntityId_ = other.maxEntityId_;
			this.transitionOption_ = ((other.transitionOption_ != null) ? other.transitionOption_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF58 RID: 48984 RVA: 0x001C6848 File Offset: 0x001C4A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinSceneNotify Clone()
		{
			return new JoinSceneNotify(this);
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x0600BF59 RID: 48985 RVA: 0x001C6850 File Offset: 0x001C4A50
		// (set) Token: 0x0600BF5A RID: 48986 RVA: 0x001C6858 File Offset: 0x001C4A58
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

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x0600BF5B RID: 48987 RVA: 0x001C6861 File Offset: 0x001C4A61
		// (set) Token: 0x0600BF5C RID: 48988 RVA: 0x001C6869 File Offset: 0x001C4A69
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

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x0600BF5D RID: 48989 RVA: 0x001C6872 File Offset: 0x001C4A72
		// (set) Token: 0x0600BF5E RID: 48990 RVA: 0x001C687A File Offset: 0x001C4A7A
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

		// Token: 0x0600BF5F RID: 48991 RVA: 0x001C6883 File Offset: 0x001C4A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinSceneNotify);
		}

		// Token: 0x0600BF60 RID: 48992 RVA: 0x001C6894 File Offset: 0x001C4A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinSceneNotify other)
		{
			return other != null && (other == this || (object.Equals(this.SceneInfo, other.SceneInfo) && this.MaxEntityId == other.MaxEntityId && object.Equals(this.TransitionOption, other.TransitionOption) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF61 RID: 48993 RVA: 0x001C68F8 File Offset: 0x001C4AF8
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

		// Token: 0x0600BF62 RID: 48994 RVA: 0x001C6963 File Offset: 0x001C4B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF63 RID: 48995 RVA: 0x001C6970 File Offset: 0x001C4B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF64 RID: 48996 RVA: 0x001C697C File Offset: 0x001C4B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.sceneInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SceneInfo);
			}
			if (this.MaxEntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.MaxEntityId);
			}
			if (this.transitionOption_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TransitionOption);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF65 RID: 48997 RVA: 0x001C69F4 File Offset: 0x001C4BF4
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

		// Token: 0x0600BF66 RID: 48998 RVA: 0x001C6A64 File Offset: 0x001C4C64
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

		// Token: 0x0600BF67 RID: 48999 RVA: 0x001C6AF8 File Offset: 0x001C4CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x001C6B04 File Offset: 0x001C4D04
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
				if (num != 42U)
				{
					if (num != 80U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						this.MaxEntityId = input.ReadInt64();
					}
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
		}

		// Token: 0x0400534F RID: 21327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005350 RID: 21328
		public const int SceneInfoFieldNumber = 5;

		// Token: 0x04005351 RID: 21329
		private SceneInformation sceneInfo_;

		// Token: 0x04005352 RID: 21330
		public const int MaxEntityIdFieldNumber = 10;

		// Token: 0x04005353 RID: 21331
		private long maxEntityId_;

		// Token: 0x04005354 RID: 21332
		public const int TransitionOptionFieldNumber = 15;

		// Token: 0x04005355 RID: 21333
		private TransitionOptionPb transitionOption_;
	}
}
