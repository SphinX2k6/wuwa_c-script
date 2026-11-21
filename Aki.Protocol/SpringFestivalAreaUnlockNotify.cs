using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E2 RID: 4834
	[NetMessage(EMessageId.SpringFestivalAreaUnlockNotify)]
	public sealed class SpringFestivalAreaUnlockNotify : IMessage<SpringFestivalAreaUnlockNotify>, IMessage, IEquatable<SpringFestivalAreaUnlockNotify>, IDeepCloneable<SpringFestivalAreaUnlockNotify>, IBufferMessage
	{
		// Token: 0x06019CCC RID: 105676 RVA: 0x003C3C9A File Offset: 0x003C1E9A
		[NullableContext(1)]
		public static SpringFestivalAreaUnlockNotify Create()
		{
			return new SpringFestivalAreaUnlockNotify();
		}

		// Token: 0x17005767 RID: 22375
		// (get) Token: 0x06019CCD RID: 105677 RVA: 0x003C3CA1 File Offset: 0x003C1EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005768 RID: 22376
		// (get) Token: 0x06019CCE RID: 105678 RVA: 0x003C3CA4 File Offset: 0x003C1EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalAreaUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06019CCF RID: 105679 RVA: 0x003C3CAB File Offset: 0x003C1EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAreaUnlockNotify()
		{
		}

		// Token: 0x06019CD0 RID: 105680 RVA: 0x003C3CC0 File Offset: 0x003C1EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAreaUnlockNotify(SpringFestivalAreaUnlockNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.areaInfos_ = other.areaInfos_.Clone();
			this.isFullLoad_ = other.isFullLoad_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CD1 RID: 105681 RVA: 0x003C3D0D File Offset: 0x003C1F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalAreaUnlockNotify Clone()
		{
			return new SpringFestivalAreaUnlockNotify(this);
		}

		// Token: 0x17005769 RID: 22377
		// (get) Token: 0x06019CD2 RID: 105682 RVA: 0x003C3D15 File Offset: 0x003C1F15
		// (set) Token: 0x06019CD3 RID: 105683 RVA: 0x003C3D1D File Offset: 0x003C1F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700576A RID: 22378
		// (get) Token: 0x06019CD4 RID: 105684 RVA: 0x003C3D26 File Offset: 0x003C1F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaInfo> AreaInfos
		{
			get
			{
				return this.areaInfos_;
			}
		}

		// Token: 0x1700576B RID: 22379
		// (get) Token: 0x06019CD5 RID: 105685 RVA: 0x003C3D2E File Offset: 0x003C1F2E
		// (set) Token: 0x06019CD6 RID: 105686 RVA: 0x003C3D36 File Offset: 0x003C1F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFullLoad
		{
			get
			{
				return this.isFullLoad_;
			}
			set
			{
				this.isFullLoad_ = value;
			}
		}

		// Token: 0x06019CD7 RID: 105687 RVA: 0x003C3D3F File Offset: 0x003C1F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalAreaUnlockNotify);
		}

		// Token: 0x06019CD8 RID: 105688 RVA: 0x003C3D50 File Offset: 0x003C1F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalAreaUnlockNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.areaInfos_.Equals(other.areaInfos_) && this.IsFullLoad == other.IsFullLoad && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019CD9 RID: 105689 RVA: 0x003C3DB0 File Offset: 0x003C1FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.areaInfos_.GetHashCode();
			if (this.IsFullLoad)
			{
				num ^= this.IsFullLoad.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019CDA RID: 105690 RVA: 0x003C3E16 File Offset: 0x003C2016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CDB RID: 105691 RVA: 0x003C3E23 File Offset: 0x003C2023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CDC RID: 105692 RVA: 0x003C3E2C File Offset: 0x003C202C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFullLoad)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsFullLoad);
			}
			this.areaInfos_.WriteTo(ref output, SpringFestivalAreaUnlockNotify._repeated_areaInfos_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019CDD RID: 105693 RVA: 0x003C3E98 File Offset: 0x003C2098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.areaInfos_.CalculateSize(SpringFestivalAreaUnlockNotify._repeated_areaInfos_codec);
			if (this.IsFullLoad)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019CDE RID: 105694 RVA: 0x003C3EF8 File Offset: 0x003C20F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalAreaUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.areaInfos_.Add(other.areaInfos_);
			if (other.IsFullLoad)
			{
				this.IsFullLoad = other.IsFullLoad;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019CDF RID: 105695 RVA: 0x003C3F59 File Offset: 0x003C2159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CE0 RID: 105696 RVA: 0x003C3F64 File Offset: 0x003C2164
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
					if (num != 66U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.areaInfos_.AddEntriesFrom(ref input, SpringFestivalAreaUnlockNotify._repeated_areaInfos_codec);
					}
				}
				else
				{
					this.IsFullLoad = input.ReadBool();
				}
			}
		}

		// Token: 0x04009858 RID: 39000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009859 RID: 39001
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x0400985A RID: 39002
		private int activityId_;

		// Token: 0x0400985B RID: 39003
		public const int AreaInfosFieldNumber = 8;

		// Token: 0x0400985C RID: 39004
		private static readonly FieldCodec<AreaInfo> _repeated_areaInfos_codec = FieldCodec.ForMessage<AreaInfo>(66U, AreaInfo.Parser);

		// Token: 0x0400985D RID: 39005
		private readonly RepeatedField<AreaInfo> areaInfos_ = new RepeatedField<AreaInfo>();

		// Token: 0x0400985E RID: 39006
		public const int IsFullLoadFieldNumber = 5;

		// Token: 0x0400985F RID: 39007
		private bool isFullLoad_;
	}
}
