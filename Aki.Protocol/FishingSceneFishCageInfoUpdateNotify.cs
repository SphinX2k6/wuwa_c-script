using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000578 RID: 1400
	[NetMessage(EMessageId.FishingSceneFishCageInfoUpdateNotify)]
	public sealed class FishingSceneFishCageInfoUpdateNotify : IMessage<FishingSceneFishCageInfoUpdateNotify>, IMessage, IEquatable<FishingSceneFishCageInfoUpdateNotify>, IDeepCloneable<FishingSceneFishCageInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008230 RID: 33328 RVA: 0x0013A321 File Offset: 0x00138521
		[NullableContext(1)]
		public static FishingSceneFishCageInfoUpdateNotify Create()
		{
			return new FishingSceneFishCageInfoUpdateNotify();
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06008231 RID: 33329 RVA: 0x0013A328 File Offset: 0x00138528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06008232 RID: 33330 RVA: 0x0013A32B File Offset: 0x0013852B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSceneFishCageInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x0013A332 File Offset: 0x00138532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSceneFishCageInfoUpdateNotify()
		{
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x0013A33C File Offset: 0x0013853C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSceneFishCageInfoUpdateNotify(FishingSceneFishCageInfoUpdateNotify other) : this()
		{
			this.sceneConfigId_ = other.sceneConfigId_;
			this.cage_ = ((other.cage_ != null) ? other.cage_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008235 RID: 33333 RVA: 0x0013A388 File Offset: 0x00138588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSceneFishCageInfoUpdateNotify Clone()
		{
			return new FishingSceneFishCageInfoUpdateNotify(this);
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06008236 RID: 33334 RVA: 0x0013A390 File Offset: 0x00138590
		// (set) Token: 0x06008237 RID: 33335 RVA: 0x0013A398 File Offset: 0x00138598
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

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06008238 RID: 33336 RVA: 0x0013A3A1 File Offset: 0x001385A1
		// (set) Token: 0x06008239 RID: 33337 RVA: 0x0013A3A9 File Offset: 0x001385A9
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

		// Token: 0x0600823A RID: 33338 RVA: 0x0013A3B2 File Offset: 0x001385B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSceneFishCageInfoUpdateNotify);
		}

		// Token: 0x0600823B RID: 33339 RVA: 0x0013A3C0 File Offset: 0x001385C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSceneFishCageInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.SceneConfigId == other.SceneConfigId && object.Equals(this.Cage, other.Cage) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600823C RID: 33340 RVA: 0x0013A410 File Offset: 0x00138610
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

		// Token: 0x0600823D RID: 33341 RVA: 0x0013A465 File Offset: 0x00138665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600823E RID: 33342 RVA: 0x0013A472 File Offset: 0x00138672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600823F RID: 33343 RVA: 0x0013A47C File Offset: 0x0013867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cage_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Cage);
			}
			if (this.SceneConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SceneConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008240 RID: 33344 RVA: 0x0013A4D8 File Offset: 0x001386D8
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

		// Token: 0x06008241 RID: 33345 RVA: 0x0013A530 File Offset: 0x00138730
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

		// Token: 0x06008242 RID: 33346 RVA: 0x0013A598 File Offset: 0x00138798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x0013A5A4 File Offset: 0x001387A4
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
				if (num != 34U)
				{
					if (num != 40U)
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
					if (this.cage_ == null)
					{
						this.Cage = new OneFishCage();
					}
					input.ReadMessage(this.Cage);
				}
			}
		}

		// Token: 0x04004130 RID: 16688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004131 RID: 16689
		public const int SceneConfigIdFieldNumber = 5;

		// Token: 0x04004132 RID: 16690
		private int sceneConfigId_;

		// Token: 0x04004133 RID: 16691
		public const int CageFieldNumber = 4;

		// Token: 0x04004134 RID: 16692
		private OneFishCage cage_;
	}
}
