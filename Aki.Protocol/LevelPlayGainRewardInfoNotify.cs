using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FC RID: 2300
	[NetMessage(EMessageId.LevelPlayGainRewardInfoNotify)]
	public sealed class LevelPlayGainRewardInfoNotify : IMessage<LevelPlayGainRewardInfoNotify>, IMessage, IEquatable<LevelPlayGainRewardInfoNotify>, IDeepCloneable<LevelPlayGainRewardInfoNotify>, IBufferMessage
	{
		// Token: 0x0600CB36 RID: 52022 RVA: 0x001DFADE File Offset: 0x001DDCDE
		[NullableContext(1)]
		public static LevelPlayGainRewardInfoNotify Create()
		{
			return new LevelPlayGainRewardInfoNotify();
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x0600CB37 RID: 52023 RVA: 0x001DFAE5 File Offset: 0x001DDCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x0600CB38 RID: 52024 RVA: 0x001DFAE8 File Offset: 0x001DDCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayGainRewardInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x001DFAEF File Offset: 0x001DDCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfoNotify()
		{
		}

		// Token: 0x0600CB3A RID: 52026 RVA: 0x001DFB02 File Offset: 0x001DDD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfoNotify(LevelPlayGainRewardInfoNotify other) : this()
		{
			this.gainRewardInfoDict_ = other.gainRewardInfoDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB3B RID: 52027 RVA: 0x001DFB2C File Offset: 0x001DDD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfoNotify Clone()
		{
			return new LevelPlayGainRewardInfoNotify(this);
		}

		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x0600CB3C RID: 52028 RVA: 0x001DFB34 File Offset: 0x001DDD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, LevelPlayGainRewardInfo> GainRewardInfoDict
		{
			get
			{
				return this.gainRewardInfoDict_;
			}
		}

		// Token: 0x0600CB3D RID: 52029 RVA: 0x001DFB3C File Offset: 0x001DDD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayGainRewardInfoNotify);
		}

		// Token: 0x0600CB3E RID: 52030 RVA: 0x001DFB4A File Offset: 0x001DDD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayGainRewardInfoNotify other)
		{
			return other != null && (other == this || (this.GainRewardInfoDict.Equals(other.GainRewardInfoDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x001DFB80 File Offset: 0x001DDD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.GainRewardInfoDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x001DFBB4 File Offset: 0x001DDDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x001DFBC1 File Offset: 0x001DDDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x001DFBCA File Offset: 0x001DDDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gainRewardInfoDict_.WriteTo(ref output, LevelPlayGainRewardInfoNotify._map_gainRewardInfoDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x001DFBF4 File Offset: 0x001DDDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gainRewardInfoDict_.CalculateSize(LevelPlayGainRewardInfoNotify._map_gainRewardInfoDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB44 RID: 52036 RVA: 0x001DFC2D File Offset: 0x001DDE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayGainRewardInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gainRewardInfoDict_.MergeFrom(other.gainRewardInfoDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB45 RID: 52037 RVA: 0x001DFC5B File Offset: 0x001DDE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB46 RID: 52038 RVA: 0x001DFC64 File Offset: 0x001DDE64
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gainRewardInfoDict_.AddEntriesFrom(ref input, LevelPlayGainRewardInfoNotify._map_gainRewardInfoDict_codec);
				}
			}
		}

		// Token: 0x04005659 RID: 22105
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400565A RID: 22106
		public const int GainRewardInfoDictFieldNumber = 8;

		// Token: 0x0400565B RID: 22107
		private static readonly MapField<int, LevelPlayGainRewardInfo>.Codec _map_gainRewardInfoDict_codec = new MapField<int, LevelPlayGainRewardInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<LevelPlayGainRewardInfo>(18U, LevelPlayGainRewardInfo.Parser), 66U);

		// Token: 0x0400565C RID: 22108
		private readonly MapField<int, LevelPlayGainRewardInfo> gainRewardInfoDict_ = new MapField<int, LevelPlayGainRewardInfo>();
	}
}
