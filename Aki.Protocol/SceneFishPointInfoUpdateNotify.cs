using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001150 RID: 4432
	[NetMessage(EMessageId.SceneFishPointInfoUpdateNotify)]
	public sealed class SceneFishPointInfoUpdateNotify : IMessage<SceneFishPointInfoUpdateNotify>, IMessage, IEquatable<SceneFishPointInfoUpdateNotify>, IDeepCloneable<SceneFishPointInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017A05 RID: 96773 RVA: 0x0036E03C File Offset: 0x0036C23C
		[NullableContext(1)]
		public static SceneFishPointInfoUpdateNotify Create()
		{
			return new SceneFishPointInfoUpdateNotify();
		}

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x06017A06 RID: 96774 RVA: 0x0036E043 File Offset: 0x0036C243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x06017A07 RID: 96775 RVA: 0x0036E046 File Offset: 0x0036C246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneFishPointInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017A08 RID: 96776 RVA: 0x0036E04D File Offset: 0x0036C24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfoUpdateNotify()
		{
		}

		// Token: 0x06017A09 RID: 96777 RVA: 0x0036E058 File Offset: 0x0036C258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfoUpdateNotify(SceneFishPointInfoUpdateNotify other) : this()
		{
			this.sceneConfigId_ = other.sceneConfigId_;
			this.fishPoint_ = ((other.fishPoint_ != null) ? other.fishPoint_.Clone() : null);
			this.isRemove_ = other.isRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017A0A RID: 96778 RVA: 0x0036E0B0 File Offset: 0x0036C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfoUpdateNotify Clone()
		{
			return new SceneFishPointInfoUpdateNotify(this);
		}

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x06017A0B RID: 96779 RVA: 0x0036E0B8 File Offset: 0x0036C2B8
		// (set) Token: 0x06017A0C RID: 96780 RVA: 0x0036E0C0 File Offset: 0x0036C2C0
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

		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x06017A0D RID: 96781 RVA: 0x0036E0C9 File Offset: 0x0036C2C9
		// (set) Token: 0x06017A0E RID: 96782 RVA: 0x0036E0D1 File Offset: 0x0036C2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishPointInfo FishPoint
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

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x06017A0F RID: 96783 RVA: 0x0036E0DA File Offset: 0x0036C2DA
		// (set) Token: 0x06017A10 RID: 96784 RVA: 0x0036E0E2 File Offset: 0x0036C2E2
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

		// Token: 0x06017A11 RID: 96785 RVA: 0x0036E0EB File Offset: 0x0036C2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneFishPointInfoUpdateNotify);
		}

		// Token: 0x06017A12 RID: 96786 RVA: 0x0036E0FC File Offset: 0x0036C2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneFishPointInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.SceneConfigId == other.SceneConfigId && object.Equals(this.FishPoint, other.FishPoint) && this.IsRemove == other.IsRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017A13 RID: 96787 RVA: 0x0036E15C File Offset: 0x0036C35C
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

		// Token: 0x06017A14 RID: 96788 RVA: 0x0036E1CA File Offset: 0x0036C3CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017A15 RID: 96789 RVA: 0x0036E1D7 File Offset: 0x0036C3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017A16 RID: 96790 RVA: 0x0036E1E0 File Offset: 0x0036C3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsRemove)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsRemove);
			}
			if (this.fishPoint_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FishPoint);
			}
			if (this.SceneConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SceneConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A17 RID: 96791 RVA: 0x0036E258 File Offset: 0x0036C458
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

		// Token: 0x06017A18 RID: 96792 RVA: 0x0036E2BC File Offset: 0x0036C4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneFishPointInfoUpdateNotify other)
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
					this.FishPoint = new OneFishPointInfo();
				}
				this.FishPoint.MergeFrom(other.FishPoint);
			}
			if (other.IsRemove)
			{
				this.IsRemove = other.IsRemove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A19 RID: 96793 RVA: 0x0036E338 File Offset: 0x0036C538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A1A RID: 96794 RVA: 0x0036E344 File Offset: 0x0036C544
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
				if (num != 40U)
				{
					if (num != 58U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SceneConfigId = input.ReadInt32();
						}
					}
					else
					{
						if (this.fishPoint_ == null)
						{
							this.FishPoint = new OneFishPointInfo();
						}
						input.ReadMessage(this.FishPoint);
					}
				}
				else
				{
					this.IsRemove = input.ReadBool();
				}
			}
		}

		// Token: 0x04008C40 RID: 35904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C41 RID: 35905
		public const int SceneConfigIdFieldNumber = 8;

		// Token: 0x04008C42 RID: 35906
		private int sceneConfigId_;

		// Token: 0x04008C43 RID: 35907
		public const int FishPointFieldNumber = 7;

		// Token: 0x04008C44 RID: 35908
		private OneFishPointInfo fishPoint_;

		// Token: 0x04008C45 RID: 35909
		public const int IsRemoveFieldNumber = 5;

		// Token: 0x04008C46 RID: 35910
		private bool isRemove_;
	}
}
