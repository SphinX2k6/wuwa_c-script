using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118A RID: 4490
	[NetMessage(EMessageId.SceneFishPointInfoUpdateNotify)]
	public sealed class SceneFishPointInfoUpdateNotify : IMessage<SceneFishPointInfoUpdateNotify>, IMessage, IEquatable<SceneFishPointInfoUpdateNotify>, IDeepCloneable<SceneFishPointInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017FA6 RID: 98214 RVA: 0x0037D388 File Offset: 0x0037B588
		[NullableContext(1)]
		public static SceneFishPointInfoUpdateNotify Create()
		{
			return new SceneFishPointInfoUpdateNotify();
		}

		// Token: 0x170050B7 RID: 20663
		// (get) Token: 0x06017FA7 RID: 98215 RVA: 0x0037D38F File Offset: 0x0037B58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050B8 RID: 20664
		// (get) Token: 0x06017FA8 RID: 98216 RVA: 0x0037D392 File Offset: 0x0037B592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneFishPointInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017FA9 RID: 98217 RVA: 0x0037D399 File Offset: 0x0037B599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfoUpdateNotify()
		{
		}

		// Token: 0x06017FAA RID: 98218 RVA: 0x0037D3A4 File Offset: 0x0037B5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfoUpdateNotify(SceneFishPointInfoUpdateNotify other) : this()
		{
			this.sceneConfigId_ = other.sceneConfigId_;
			this.fishPoint_ = ((other.fishPoint_ != null) ? other.fishPoint_.Clone() : null);
			this.isRemove_ = other.isRemove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FAB RID: 98219 RVA: 0x0037D3FC File Offset: 0x0037B5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfoUpdateNotify Clone()
		{
			return new SceneFishPointInfoUpdateNotify(this);
		}

		// Token: 0x170050B9 RID: 20665
		// (get) Token: 0x06017FAC RID: 98220 RVA: 0x0037D404 File Offset: 0x0037B604
		// (set) Token: 0x06017FAD RID: 98221 RVA: 0x0037D40C File Offset: 0x0037B60C
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

		// Token: 0x170050BA RID: 20666
		// (get) Token: 0x06017FAE RID: 98222 RVA: 0x0037D415 File Offset: 0x0037B615
		// (set) Token: 0x06017FAF RID: 98223 RVA: 0x0037D41D File Offset: 0x0037B61D
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

		// Token: 0x170050BB RID: 20667
		// (get) Token: 0x06017FB0 RID: 98224 RVA: 0x0037D426 File Offset: 0x0037B626
		// (set) Token: 0x06017FB1 RID: 98225 RVA: 0x0037D42E File Offset: 0x0037B62E
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

		// Token: 0x06017FB2 RID: 98226 RVA: 0x0037D437 File Offset: 0x0037B637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneFishPointInfoUpdateNotify);
		}

		// Token: 0x06017FB3 RID: 98227 RVA: 0x0037D448 File Offset: 0x0037B648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneFishPointInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.SceneConfigId == other.SceneConfigId && object.Equals(this.FishPoint, other.FishPoint) && this.IsRemove == other.IsRemove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FB4 RID: 98228 RVA: 0x0037D4A8 File Offset: 0x0037B6A8
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

		// Token: 0x06017FB5 RID: 98229 RVA: 0x0037D516 File Offset: 0x0037B716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FB6 RID: 98230 RVA: 0x0037D523 File Offset: 0x0037B723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FB7 RID: 98231 RVA: 0x0037D52C File Offset: 0x0037B72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishPoint_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.FishPoint);
			}
			if (this.IsRemove)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsRemove);
			}
			if (this.SceneConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SceneConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FB8 RID: 98232 RVA: 0x0037D5A4 File Offset: 0x0037B7A4
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

		// Token: 0x06017FB9 RID: 98233 RVA: 0x0037D608 File Offset: 0x0037B808
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

		// Token: 0x06017FBA RID: 98234 RVA: 0x0037D684 File Offset: 0x0037B884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FBB RID: 98235 RVA: 0x0037D690 File Offset: 0x0037B890
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
					if (num != 72U)
					{
						if (num != 88U)
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
						this.IsRemove = input.ReadBool();
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
		}

		// Token: 0x04008ED3 RID: 36563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ED4 RID: 36564
		public const int SceneConfigIdFieldNumber = 11;

		// Token: 0x04008ED5 RID: 36565
		private int sceneConfigId_;

		// Token: 0x04008ED6 RID: 36566
		public const int FishPointFieldNumber = 3;

		// Token: 0x04008ED7 RID: 36567
		private OneFishPointInfo fishPoint_;

		// Token: 0x04008ED8 RID: 36568
		public const int IsRemoveFieldNumber = 9;

		// Token: 0x04008ED9 RID: 36569
		private bool isRemove_;
	}
}
