using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011A6 RID: 4518
	[NetMessage(EMessageId.SceneItemMoveTargetRequest)]
	public sealed class SceneItemMoveTargetRequest : IMessage<SceneItemMoveTargetRequest>, IMessage, IEquatable<SceneItemMoveTargetRequest>, IDeepCloneable<SceneItemMoveTargetRequest>, IBufferMessage
	{
		// Token: 0x0601821A RID: 98842 RVA: 0x00383928 File Offset: 0x00381B28
		[NullableContext(1)]
		public static SceneItemMoveTargetRequest Create()
		{
			return new SceneItemMoveTargetRequest();
		}

		// Token: 0x1700514F RID: 20815
		// (get) Token: 0x0601821B RID: 98843 RVA: 0x0038392F File Offset: 0x00381B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005150 RID: 20816
		// (get) Token: 0x0601821C RID: 98844 RVA: 0x00383932 File Offset: 0x00381B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemMoveTargetRequest.Descriptor;
			}
		}

		// Token: 0x0601821D RID: 98845 RVA: 0x00383939 File Offset: 0x00381B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetRequest()
		{
		}

		// Token: 0x0601821E RID: 98846 RVA: 0x00383944 File Offset: 0x00381B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetRequest(SceneItemMoveTargetRequest other) : this()
		{
			this.moveInfo_ = ((other.moveInfo_ != null) ? other.moveInfo_.Clone() : null);
			this.sceneOwnerId_ = other.sceneOwnerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601821F RID: 98847 RVA: 0x00383990 File Offset: 0x00381B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetRequest Clone()
		{
			return new SceneItemMoveTargetRequest(this);
		}

		// Token: 0x17005151 RID: 20817
		// (get) Token: 0x06018220 RID: 98848 RVA: 0x00383998 File Offset: 0x00381B98
		// (set) Token: 0x06018221 RID: 98849 RVA: 0x003839A0 File Offset: 0x00381BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemMoveTargetInfo MoveInfo
		{
			get
			{
				return this.moveInfo_;
			}
			set
			{
				this.moveInfo_ = value;
			}
		}

		// Token: 0x17005152 RID: 20818
		// (get) Token: 0x06018222 RID: 98850 RVA: 0x003839A9 File Offset: 0x00381BA9
		// (set) Token: 0x06018223 RID: 98851 RVA: 0x003839B1 File Offset: 0x00381BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneOwnerId
		{
			get
			{
				return this.sceneOwnerId_;
			}
			set
			{
				this.sceneOwnerId_ = value;
			}
		}

		// Token: 0x06018224 RID: 98852 RVA: 0x003839BA File Offset: 0x00381BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemMoveTargetRequest);
		}

		// Token: 0x06018225 RID: 98853 RVA: 0x003839C8 File Offset: 0x00381BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemMoveTargetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MoveInfo, other.MoveInfo) && this.SceneOwnerId == other.SceneOwnerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018226 RID: 98854 RVA: 0x00383A18 File Offset: 0x00381C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.moveInfo_ != null)
			{
				num ^= this.MoveInfo.GetHashCode();
			}
			if (this.SceneOwnerId != 0)
			{
				num ^= this.SceneOwnerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018227 RID: 98855 RVA: 0x00383A6D File Offset: 0x00381C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018228 RID: 98856 RVA: 0x00383A7A File Offset: 0x00381C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018229 RID: 98857 RVA: 0x00383A84 File Offset: 0x00381C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SceneOwnerId);
			}
			if (this.moveInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.MoveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601822A RID: 98858 RVA: 0x00383ADC File Offset: 0x00381CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.moveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveInfo);
			}
			if (this.SceneOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneOwnerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601822B RID: 98859 RVA: 0x00383B34 File Offset: 0x00381D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemMoveTargetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.moveInfo_ != null)
			{
				if (this.moveInfo_ == null)
				{
					this.MoveInfo = new SceneItemMoveTargetInfo();
				}
				this.MoveInfo.MergeFrom(other.MoveInfo);
			}
			if (other.SceneOwnerId != 0)
			{
				this.SceneOwnerId = other.SceneOwnerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601822C RID: 98860 RVA: 0x00383B9C File Offset: 0x00381D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601822D RID: 98861 RVA: 0x00383BA8 File Offset: 0x00381DA8
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.moveInfo_ == null)
						{
							this.MoveInfo = new SceneItemMoveTargetInfo();
						}
						input.ReadMessage(this.MoveInfo);
					}
				}
				else
				{
					this.SceneOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008FAA RID: 36778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FAB RID: 36779
		public const int MoveInfoFieldNumber = 12;

		// Token: 0x04008FAC RID: 36780
		private SceneItemMoveTargetInfo moveInfo_;

		// Token: 0x04008FAD RID: 36781
		public const int SceneOwnerIdFieldNumber = 1;

		// Token: 0x04008FAE RID: 36782
		private int sceneOwnerId_;
	}
}
