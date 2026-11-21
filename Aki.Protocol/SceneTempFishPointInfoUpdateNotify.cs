using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011CC RID: 4556
	[NetMessage(EMessageId.SceneTempFishPointInfoUpdateNotify)]
	public sealed class SceneTempFishPointInfoUpdateNotify : IMessage<SceneTempFishPointInfoUpdateNotify>, IMessage, IEquatable<SceneTempFishPointInfoUpdateNotify>, IDeepCloneable<SceneTempFishPointInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601852F RID: 99631 RVA: 0x0038A731 File Offset: 0x00388931
		[NullableContext(1)]
		public static SceneTempFishPointInfoUpdateNotify Create()
		{
			return new SceneTempFishPointInfoUpdateNotify();
		}

		// Token: 0x170051FA RID: 20986
		// (get) Token: 0x06018530 RID: 99632 RVA: 0x0038A738 File Offset: 0x00388938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051FB RID: 20987
		// (get) Token: 0x06018531 RID: 99633 RVA: 0x0038A73B File Offset: 0x0038893B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneTempFishPointInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018532 RID: 99634 RVA: 0x0038A742 File Offset: 0x00388942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTempFishPointInfoUpdateNotify()
		{
		}

		// Token: 0x06018533 RID: 99635 RVA: 0x0038A74C File Offset: 0x0038894C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTempFishPointInfoUpdateNotify(SceneTempFishPointInfoUpdateNotify other) : this()
		{
			this.sceneConfigId_ = other.sceneConfigId_;
			this.fishPoint_ = ((other.fishPoint_ != null) ? other.fishPoint_.Clone() : null);
			this.isRemove_ = other.isRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018534 RID: 99636 RVA: 0x0038A7A4 File Offset: 0x003889A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTempFishPointInfoUpdateNotify Clone()
		{
			return new SceneTempFishPointInfoUpdateNotify(this);
		}

		// Token: 0x170051FC RID: 20988
		// (get) Token: 0x06018535 RID: 99637 RVA: 0x0038A7AC File Offset: 0x003889AC
		// (set) Token: 0x06018536 RID: 99638 RVA: 0x0038A7B4 File Offset: 0x003889B4
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

		// Token: 0x170051FD RID: 20989
		// (get) Token: 0x06018537 RID: 99639 RVA: 0x0038A7BD File Offset: 0x003889BD
		// (set) Token: 0x06018538 RID: 99640 RVA: 0x0038A7C5 File Offset: 0x003889C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TempFishPointInfo FishPoint
		{
			get
			{
				return this.fishPoint_;
			}
			set
			{
				this.fishPoint_ = value;
			}
		}

		// Token: 0x170051FE RID: 20990
		// (get) Token: 0x06018539 RID: 99641 RVA: 0x0038A7CE File Offset: 0x003889CE
		// (set) Token: 0x0601853A RID: 99642 RVA: 0x0038A7D6 File Offset: 0x003889D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRemove
		{
			get
			{
				return this.isRemove_;
			}
			set
			{
				this.isRemove_ = value;
			}
		}

		// Token: 0x0601853B RID: 99643 RVA: 0x0038A7DF File Offset: 0x003889DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneTempFishPointInfoUpdateNotify);
		}

		// Token: 0x0601853C RID: 99644 RVA: 0x0038A7F0 File Offset: 0x003889F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneTempFishPointInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.SceneConfigId == other.SceneConfigId && object.Equals(this.FishPoint, other.FishPoint) && this.IsRemove == other.IsRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601853D RID: 99645 RVA: 0x0038A850 File Offset: 0x00388A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SceneConfigId != 0)
			{
				num ^= this.SceneConfigId.GetHashCode();
			}
			if (this.fishPoint_ != null)
			{
				num ^= this.FishPoint.GetHashCode();
			}
			if (this.IsRemove)
			{
				num ^= this.IsRemove.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601853E RID: 99646 RVA: 0x0038A8BE File Offset: 0x00388ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601853F RID: 99647 RVA: 0x0038A8CB File Offset: 0x00388ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018540 RID: 99648 RVA: 0x0038A8D4 File Offset: 0x00388AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SceneConfigId);
			}
			if (this.IsRemove)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsRemove);
			}
			if (this.fishPoint_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.FishPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018541 RID: 99649 RVA: 0x0038A94C File Offset: 0x00388B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SceneConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SceneConfigId);
			}
			if (this.fishPoint_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishPoint);
			}
			if (this.IsRemove)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018542 RID: 99650 RVA: 0x0038A9B0 File Offset: 0x00388BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneTempFishPointInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SceneConfigId != 0)
			{
				this.SceneConfigId = other.SceneConfigId;
			}
			if (other.fishPoint_ != null)
			{
				if (this.fishPoint_ == null)
				{
					this.FishPoint = new TempFishPointInfo();
				}
				this.FishPoint.MergeFrom(other.FishPoint);
			}
			if (other.IsRemove)
			{
				this.IsRemove = other.IsRemove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018543 RID: 99651 RVA: 0x0038AA2C File Offset: 0x00388C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018544 RID: 99652 RVA: 0x0038AA38 File Offset: 0x00388C38
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.fishPoint_ == null)
							{
								this.FishPoint = new TempFishPointInfo();
							}
							input.ReadMessage(this.FishPoint);
						}
					}
					else
					{
						this.IsRemove = input.ReadBool();
					}
				}
				else
				{
					this.SceneConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009095 RID: 37013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009096 RID: 37014
		public const int SceneConfigIdFieldNumber = 3;

		// Token: 0x04009097 RID: 37015
		private int sceneConfigId_;

		// Token: 0x04009098 RID: 37016
		public const int FishPointFieldNumber = 12;

		// Token: 0x04009099 RID: 37017
		private TempFishPointInfo fishPoint_;

		// Token: 0x0400909A RID: 37018
		public const int IsRemoveFieldNumber = 11;

		// Token: 0x0400909B RID: 37019
		private bool isRemove_;
	}
}
