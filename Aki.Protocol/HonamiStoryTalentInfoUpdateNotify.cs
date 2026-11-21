using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000793 RID: 1939
	[NetMessage(EMessageId.HonamiStoryTalentInfoUpdateNotify)]
	public sealed class HonamiStoryTalentInfoUpdateNotify : IMessage<HonamiStoryTalentInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryTalentInfoUpdateNotify>, IDeepCloneable<HonamiStoryTalentInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AF39 RID: 44857 RVA: 0x001A4CBB File Offset: 0x001A2EBB
		[NullableContext(1)]
		public static HonamiStoryTalentInfoUpdateNotify Create()
		{
			return new HonamiStoryTalentInfoUpdateNotify();
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x001A4CC2 File Offset: 0x001A2EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x0600AF3B RID: 44859 RVA: 0x001A4CC5 File Offset: 0x001A2EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTalentInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x001A4CCC File Offset: 0x001A2ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfoUpdateNotify()
		{
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x001A4CDF File Offset: 0x001A2EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfoUpdateNotify(HonamiStoryTalentInfoUpdateNotify other) : this()
		{
			this.honamiStoryTalentInfos_ = other.honamiStoryTalentInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF3E RID: 44862 RVA: 0x001A4D09 File Offset: 0x001A2F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfoUpdateNotify Clone()
		{
			return new HonamiStoryTalentInfoUpdateNotify(this);
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x0600AF3F RID: 44863 RVA: 0x001A4D11 File Offset: 0x001A2F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryTalentInfo> HonamiStoryTalentInfos
		{
			get
			{
				return this.honamiStoryTalentInfos_;
			}
		}

		// Token: 0x0600AF40 RID: 44864 RVA: 0x001A4D19 File Offset: 0x001A2F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTalentInfoUpdateNotify);
		}

		// Token: 0x0600AF41 RID: 44865 RVA: 0x001A4D27 File Offset: 0x001A2F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTalentInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.honamiStoryTalentInfos_.Equals(other.honamiStoryTalentInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x001A4D5C File Offset: 0x001A2F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.honamiStoryTalentInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x001A4D90 File Offset: 0x001A2F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x001A4D9D File Offset: 0x001A2F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF45 RID: 44869 RVA: 0x001A4DA6 File Offset: 0x001A2FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.honamiStoryTalentInfos_.WriteTo(ref output, HonamiStoryTalentInfoUpdateNotify._repeated_honamiStoryTalentInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF46 RID: 44870 RVA: 0x001A4DD0 File Offset: 0x001A2FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.honamiStoryTalentInfos_.CalculateSize(HonamiStoryTalentInfoUpdateNotify._repeated_honamiStoryTalentInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF47 RID: 44871 RVA: 0x001A4E09 File Offset: 0x001A3009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTalentInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.honamiStoryTalentInfos_.Add(other.honamiStoryTalentInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF48 RID: 44872 RVA: 0x001A4E37 File Offset: 0x001A3037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF49 RID: 44873 RVA: 0x001A4E40 File Offset: 0x001A3040
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.honamiStoryTalentInfos_.AddEntriesFrom(ref input, HonamiStoryTalentInfoUpdateNotify._repeated_honamiStoryTalentInfos_codec);
				}
			}
		}

		// Token: 0x04004F44 RID: 20292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F45 RID: 20293
		public const int HonamiStoryTalentInfosFieldNumber = 10;

		// Token: 0x04004F46 RID: 20294
		private static readonly FieldCodec<HonamiStoryTalentInfo> _repeated_honamiStoryTalentInfos_codec = FieldCodec.ForMessage<HonamiStoryTalentInfo>(82U, HonamiStoryTalentInfo.Parser);

		// Token: 0x04004F47 RID: 20295
		private readonly RepeatedField<HonamiStoryTalentInfo> honamiStoryTalentInfos_ = new RepeatedField<HonamiStoryTalentInfo>();
	}
}
