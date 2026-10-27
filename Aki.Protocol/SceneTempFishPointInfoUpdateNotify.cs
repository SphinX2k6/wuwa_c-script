using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001192 RID: 4498
	[NetMessage(EMessageId.SceneTempFishPointInfoUpdateNotify)]
	public sealed class SceneTempFishPointInfoUpdateNotify : IMessage<SceneTempFishPointInfoUpdateNotify>, IMessage, IEquatable<SceneTempFishPointInfoUpdateNotify>, IDeepCloneable<SceneTempFishPointInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017F8E RID: 98190 RVA: 0x0037B3F1 File Offset: 0x003795F1
		[NullableContext(1)]
		public static SceneTempFishPointInfoUpdateNotify Create()
		{
			return new SceneTempFishPointInfoUpdateNotify();
		}

		// Token: 0x1700508E RID: 20622
		// (get) Token: 0x06017F8F RID: 98191 RVA: 0x0037B3F8 File Offset: 0x003795F8
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
		// (get) Token: 0x06017F90 RID: 98192 RVA: 0x0037B3FB File Offset: 0x003795FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneTempFishPointInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017F91 RID: 98193 RVA: 0x0037B402 File Offset: 0x00379602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTempFishPointInfoUpdateNotify()
		{
		}

		// Token: 0x06017F92 RID: 98194 RVA: 0x0037B40C File Offset: 0x0037960C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTempFishPointInfoUpdateNotify(SceneTempFishPointInfoUpdateNotify other) : this()
		{
			this.sceneConfigId_ = other.sceneConfigId_;
			this.fishPoint_ = ((other.fishPoint_ != null) ? other.fishPoint_.Clone() : null);
			this.isRemove_ = other.isRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F93 RID: 98195 RVA: 0x0037B464 File Offset: 0x00379664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTempFishPointInfoUpdateNotify Clone()
		{
			return new SceneTempFishPointInfoUpdateNotify(this);
		}

		// Token: 0x17005090 RID: 20624
		// (get) Token: 0x06017F94 RID: 98196 RVA: 0x0037B46C File Offset: 0x0037966C
		// (set) Token: 0x06017F95 RID: 98197 RVA: 0x0037B474 File Offset: 0x00379674
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

		// Token: 0x17005091 RID: 20625
		// (get) Token: 0x06017F96 RID: 98198 RVA: 0x0037B47D File Offset: 0x0037967D
		// (set) Token: 0x06017F97 RID: 98199 RVA: 0x0037B485 File Offset: 0x00379685
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

		// Token: 0x17005092 RID: 20626
		// (get) Token: 0x06017F98 RID: 98200 RVA: 0x0037B48E File Offset: 0x0037968E
		// (set) Token: 0x06017F99 RID: 98201 RVA: 0x0037B496 File Offset: 0x00379696
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

		// Token: 0x06017F9A RID: 98202 RVA: 0x0037B49F File Offset: 0x0037969F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneTempFishPointInfoUpdateNotify);
		}

		// Token: 0x06017F9B RID: 98203 RVA: 0x0037B4B0 File Offset: 0x003796B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneTempFishPointInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.SceneConfigId == other.SceneConfigId && object.Equals(this.FishPoint, other.FishPoint) && this.IsRemove == other.IsRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F9C RID: 98204 RVA: 0x0037B510 File Offset: 0x00379710
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

		// Token: 0x06017F9D RID: 98205 RVA: 0x0037B57E File Offset: 0x0037977E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F9E RID: 98206 RVA: 0x0037B58B File Offset: 0x0037978B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F9F RID: 98207 RVA: 0x0037B594 File Offset: 0x00379794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SceneConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SceneConfigId);
			}
			if (this.fishPoint_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.FishPoint);
			}
			if (this.IsRemove)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsRemove);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FA0 RID: 98208 RVA: 0x0037B60C File Offset: 0x0037980C
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

		// Token: 0x06017FA1 RID: 98209 RVA: 0x0037B670 File Offset: 0x00379870
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

		// Token: 0x06017FA2 RID: 98210 RVA: 0x0037B6EC File Offset: 0x003798EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FA3 RID: 98211 RVA: 0x0037B6F8 File Offset: 0x003798F8
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
					if (num != 82U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsRemove = input.ReadBool();
						}
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
					this.SceneConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E02 RID: 36354
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E03 RID: 36355
		public const int SceneConfigIdFieldNumber = 5;

		// Token: 0x04008E04 RID: 36356
		private int sceneConfigId_;

		// Token: 0x04008E05 RID: 36357
		public const int FishPointFieldNumber = 10;

		// Token: 0x04008E06 RID: 36358
		private TempFishPointInfo fishPoint_;

		// Token: 0x04008E07 RID: 36359
		public const int IsRemoveFieldNumber = 11;

		// Token: 0x04008E08 RID: 36360
		private bool isRemove_;
	}
}
