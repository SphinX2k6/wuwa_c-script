using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000563 RID: 1379
	[NetMessage(EMessageId.FishingSceneFishCageInfoUpdateNotify)]
	public sealed class FishingSceneFishCageInfoUpdateNotify : IMessage<FishingSceneFishCageInfoUpdateNotify>, IMessage, IEquatable<FishingSceneFishCageInfoUpdateNotify>, IDeepCloneable<FishingSceneFishCageInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060080C8 RID: 32968 RVA: 0x0013771D File Offset: 0x0013591D
		[NullableContext(1)]
		public static FishingSceneFishCageInfoUpdateNotify Create()
		{
			return new FishingSceneFishCageInfoUpdateNotify();
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060080C9 RID: 32969 RVA: 0x00137724 File Offset: 0x00135924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060080CA RID: 32970 RVA: 0x00137727 File Offset: 0x00135927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSceneFishCageInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x0013772E File Offset: 0x0013592E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSceneFishCageInfoUpdateNotify()
		{
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x00137738 File Offset: 0x00135938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSceneFishCageInfoUpdateNotify(FishingSceneFishCageInfoUpdateNotify other) : this()
		{
			this.sceneConfigId_ = other.sceneConfigId_;
			this.cage_ = ((other.cage_ != null) ? other.cage_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x00137784 File Offset: 0x00135984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSceneFishCageInfoUpdateNotify Clone()
		{
			return new FishingSceneFishCageInfoUpdateNotify(this);
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060080CE RID: 32974 RVA: 0x0013778C File Offset: 0x0013598C
		// (set) Token: 0x060080CF RID: 32975 RVA: 0x00137794 File Offset: 0x00135994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SceneConfigId
		{
			get
			{
				return this.sceneConfigId_;
			}
			set
			{
				this.sceneConfigId_ = value;
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060080D0 RID: 32976 RVA: 0x0013779D File Offset: 0x0013599D
		// (set) Token: 0x060080D1 RID: 32977 RVA: 0x001377A5 File Offset: 0x001359A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage Cage
		{
			get
			{
				return this.cage_;
			}
			set
			{
				this.cage_ = value;
			}
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x001377AE File Offset: 0x001359AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSceneFishCageInfoUpdateNotify);
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x001377BC File Offset: 0x001359BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSceneFishCageInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.SceneConfigId == other.SceneConfigId && object.Equals(this.Cage, other.Cage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x0013780C File Offset: 0x00135A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneConfigId != 0)
			{
				num ^= this.SceneConfigId.GetHashCode();
			}
			if (this.cage_ != null)
			{
				num ^= this.Cage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x00137861 File Offset: 0x00135A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080D6 RID: 32982 RVA: 0x0013786E File Offset: 0x00135A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x00137878 File Offset: 0x00135A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SceneConfigId);
			}
			if (this.cage_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Cage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x001378D4 File Offset: 0x00135AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneConfigId);
			}
			if (this.cage_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Cage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x0013792C File Offset: 0x00135B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSceneFishCageInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneConfigId != 0)
			{
				this.SceneConfigId = other.SceneConfigId;
			}
			if (other.cage_ != null)
			{
				if (this.cage_ == null)
				{
					this.Cage = new OneFishCage();
				}
				this.Cage.MergeFrom(other.Cage);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x00137994 File Offset: 0x00135B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x001379A0 File Offset: 0x00135BA0
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.cage_ == null)
						{
							this.Cage = new OneFishCage();
						}
						input.ReadMessage(this.Cage);
					}
				}
				else
				{
					this.SceneConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004126 RID: 16678
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004127 RID: 16679
		public const int SceneConfigIdFieldNumber = 11;

		// Token: 0x04004128 RID: 16680
		private int sceneConfigId_;

		// Token: 0x04004129 RID: 16681
		public const int CageFieldNumber = 13;

		// Token: 0x0400412A RID: 16682
		private OneFishCage cage_;
	}
}
