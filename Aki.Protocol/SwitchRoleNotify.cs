using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001304 RID: 4868
	[NetMessage(EMessageId.SwitchRoleNotify)]
	public sealed class SwitchRoleNotify : IMessage<SwitchRoleNotify>, IMessage, IEquatable<SwitchRoleNotify>, IDeepCloneable<SwitchRoleNotify>, IBufferMessage
	{
		// Token: 0x06019DFC RID: 105980 RVA: 0x003C2592 File Offset: 0x003C0792
		[NullableContext(1)]
		public static SwitchRoleNotify Create()
		{
			return new SwitchRoleNotify();
		}

		// Token: 0x1700573E RID: 22334
		// (get) Token: 0x06019DFD RID: 105981 RVA: 0x003C2599 File Offset: 0x003C0799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700573F RID: 22335
		// (get) Token: 0x06019DFE RID: 105982 RVA: 0x003C259C File Offset: 0x003C079C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchRoleNotify.Descriptor;
			}
		}

		// Token: 0x06019DFF RID: 105983 RVA: 0x003C25A3 File Offset: 0x003C07A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleNotify()
		{
		}

		// Token: 0x06019E00 RID: 105984 RVA: 0x003C25AC File Offset: 0x003C07AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleNotify(SwitchRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.upEntityId_ = other.upEntityId_;
			this.downEntityId_ = other.downEntityId_;
			this.onStageWithoutControl_ = other.onStageWithoutControl_;
			this.transform_ = ((other.transform_ != null) ? other.transform_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E01 RID: 105985 RVA: 0x003C261C File Offset: 0x003C081C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchRoleNotify Clone()
		{
			return new SwitchRoleNotify(this);
		}

		// Token: 0x17005740 RID: 22336
		// (get) Token: 0x06019E02 RID: 105986 RVA: 0x003C2624 File Offset: 0x003C0824
		// (set) Token: 0x06019E03 RID: 105987 RVA: 0x003C262C File Offset: 0x003C082C
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

		// Token: 0x17005741 RID: 22337
		// (get) Token: 0x06019E04 RID: 105988 RVA: 0x003C2635 File Offset: 0x003C0835
		// (set) Token: 0x06019E05 RID: 105989 RVA: 0x003C263D File Offset: 0x003C083D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpEntityId
		{
			get
			{
				return this.upEntityId_;
			}
			set
			{
				this.upEntityId_ = value;
			}
		}

		// Token: 0x17005742 RID: 22338
		// (get) Token: 0x06019E06 RID: 105990 RVA: 0x003C2646 File Offset: 0x003C0846
		// (set) Token: 0x06019E07 RID: 105991 RVA: 0x003C264E File Offset: 0x003C084E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DownEntityId
		{
			get
			{
				return this.downEntityId_;
			}
			set
			{
				this.downEntityId_ = value;
			}
		}

		// Token: 0x17005743 RID: 22339
		// (get) Token: 0x06019E08 RID: 105992 RVA: 0x003C2657 File Offset: 0x003C0857
		// (set) Token: 0x06019E09 RID: 105993 RVA: 0x003C265F File Offset: 0x003C085F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool OnStageWithoutControl
		{
			get
			{
				return this.onStageWithoutControl_;
			}
			set
			{
				this.onStageWithoutControl_ = value;
			}
		}

		// Token: 0x17005744 RID: 22340
		// (get) Token: 0x06019E0A RID: 105994 RVA: 0x003C2668 File Offset: 0x003C0868
		// (set) Token: 0x06019E0B RID: 105995 RVA: 0x003C2670 File Offset: 0x003C0870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Transform
		{
			get
			{
				return this.transform_;
			}
			set
			{
				this.transform_ = value;
			}
		}

		// Token: 0x06019E0C RID: 105996 RVA: 0x003C2679 File Offset: 0x003C0879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchRoleNotify);
		}

		// Token: 0x06019E0D RID: 105997 RVA: 0x003C2688 File Offset: 0x003C0888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.UpEntityId == other.UpEntityId && this.DownEntityId == other.DownEntityId && this.OnStageWithoutControl == other.OnStageWithoutControl && object.Equals(this.Transform, other.Transform) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E0E RID: 105998 RVA: 0x003C2708 File Offset: 0x003C0908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.UpEntityId != 0L)
			{
				num ^= this.UpEntityId.GetHashCode();
			}
			if (this.DownEntityId != 0L)
			{
				num ^= this.DownEntityId.GetHashCode();
			}
			if (this.OnStageWithoutControl)
			{
				num ^= this.OnStageWithoutControl.GetHashCode();
			}
			if (this.transform_ != null)
			{
				num ^= this.Transform.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E0F RID: 105999 RVA: 0x003C27A8 File Offset: 0x003C09A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E10 RID: 106000 RVA: 0x003C27B5 File Offset: 0x003C09B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E11 RID: 106001 RVA: 0x003C27C0 File Offset: 0x003C09C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OnStageWithoutControl)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.OnStageWithoutControl);
			}
			if (this.DownEntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.DownEntityId);
			}
			if (this.transform_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Transform);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PlayerId);
			}
			if (this.UpEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.UpEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E12 RID: 106002 RVA: 0x003C286C File Offset: 0x003C0A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.UpEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpEntityId);
			}
			if (this.DownEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DownEntityId);
			}
			if (this.OnStageWithoutControl)
			{
				num += 2;
			}
			if (this.transform_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E13 RID: 106003 RVA: 0x003C2900 File Offset: 0x003C0B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.UpEntityId != 0L)
			{
				this.UpEntityId = other.UpEntityId;
			}
			if (other.DownEntityId != 0L)
			{
				this.DownEntityId = other.DownEntityId;
			}
			if (other.OnStageWithoutControl)
			{
				this.OnStageWithoutControl = other.OnStageWithoutControl;
			}
			if (other.transform_ != null)
			{
				if (this.transform_ == null)
				{
					this.Transform = new Transform();
				}
				this.Transform.MergeFrom(other.Transform);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E14 RID: 106004 RVA: 0x003C29A4 File Offset: 0x003C0BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E15 RID: 106005 RVA: 0x003C29B0 File Offset: 0x003C0BB0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.OnStageWithoutControl = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.DownEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.transform_ == null)
						{
							this.Transform = new Transform();
						}
						input.ReadMessage(this.Transform);
						continue;
					}
					if (num == 64U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.UpEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009743 RID: 38723
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009744 RID: 38724
		public const int PlayerIdFieldNumber = 8;

		// Token: 0x04009745 RID: 38725
		private int playerId_;

		// Token: 0x04009746 RID: 38726
		public const int UpEntityIdFieldNumber = 14;

		// Token: 0x04009747 RID: 38727
		private long upEntityId_;

		// Token: 0x04009748 RID: 38728
		public const int DownEntityIdFieldNumber = 2;

		// Token: 0x04009749 RID: 38729
		private long downEntityId_;

		// Token: 0x0400974A RID: 38730
		public const int OnStageWithoutControlFieldNumber = 1;

		// Token: 0x0400974B RID: 38731
		private bool onStageWithoutControl_;

		// Token: 0x0400974C RID: 38732
		public const int TransformFieldNumber = 7;

		// Token: 0x0400974D RID: 38733
		private Transform transform_;
	}
}
