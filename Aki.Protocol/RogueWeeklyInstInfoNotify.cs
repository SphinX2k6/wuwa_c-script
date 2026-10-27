using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103A RID: 4154
	[NetMessage(EMessageId.RogueWeeklyInstInfoNotify)]
	public sealed class RogueWeeklyInstInfoNotify : IMessage<RogueWeeklyInstInfoNotify>, IMessage, IEquatable<RogueWeeklyInstInfoNotify>, IDeepCloneable<RogueWeeklyInstInfoNotify>, IBufferMessage
	{
		// Token: 0x06016333 RID: 90931 RVA: 0x00339A95 File Offset: 0x00337C95
		[NullableContext(1)]
		public static RogueWeeklyInstInfoNotify Create()
		{
			return new RogueWeeklyInstInfoNotify();
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x06016334 RID: 90932 RVA: 0x00339A9C File Offset: 0x00337C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x06016335 RID: 90933 RVA: 0x00339A9F File Offset: 0x00337C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyInstInfoNotify.Descriptor;
			}
		}

		// Token: 0x06016336 RID: 90934 RVA: 0x00339AA6 File Offset: 0x00337CA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInstInfoNotify()
		{
		}

		// Token: 0x06016337 RID: 90935 RVA: 0x00339AC4 File Offset: 0x00337CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInstInfoNotify(RogueWeeklyInstInfoNotify other) : this()
		{
			this.rogueWeeklyBuffs_ = other.rogueWeeklyBuffs_.Clone();
			this.rogueWeeklyOptions_ = other.rogueWeeklyOptions_.Clone();
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016338 RID: 90936 RVA: 0x00339B16 File Offset: 0x00337D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInstInfoNotify Clone()
		{
			return new RogueWeeklyInstInfoNotify(this);
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x06016339 RID: 90937 RVA: 0x00339B1E File Offset: 0x00337D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RogueWeeklyBuffs
		{
			get
			{
				return this.rogueWeeklyBuffs_;
			}
		}

		// Token: 0x17004A3A RID: 19002
		// (get) Token: 0x0601633A RID: 90938 RVA: 0x00339B26 File Offset: 0x00337D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, RogueWeeklyOption> RogueWeeklyOptions
		{
			get
			{
				return this.rogueWeeklyOptions_;
			}
		}

		// Token: 0x17004A3B RID: 19003
		// (get) Token: 0x0601633B RID: 90939 RVA: 0x00339B2E File Offset: 0x00337D2E
		// (set) Token: 0x0601633C RID: 90940 RVA: 0x00339B36 File Offset: 0x00337D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x0601633D RID: 90941 RVA: 0x00339B3F File Offset: 0x00337D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyInstInfoNotify);
		}

		// Token: 0x0601633E RID: 90942 RVA: 0x00339B50 File Offset: 0x00337D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyInstInfoNotify other)
		{
			return other != null && (other == this || (this.rogueWeeklyBuffs_.Equals(other.rogueWeeklyBuffs_) && this.RogueWeeklyOptions.Equals(other.RogueWeeklyOptions) && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601633F RID: 90943 RVA: 0x00339BB4 File Offset: 0x00337DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueWeeklyBuffs_.GetHashCode();
			num ^= this.RogueWeeklyOptions.GetHashCode();
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016340 RID: 90944 RVA: 0x00339C0F File Offset: 0x00337E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016341 RID: 90945 RVA: 0x00339C1C File Offset: 0x00337E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016342 RID: 90946 RVA: 0x00339C28 File Offset: 0x00337E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			this.rogueWeeklyBuffs_.WriteTo(ref output, RogueWeeklyInstInfoNotify._repeated_rogueWeeklyBuffs_codec);
			this.rogueWeeklyOptions_.WriteTo(ref output, RogueWeeklyInstInfoNotify._map_rogueWeeklyOptions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016343 RID: 90947 RVA: 0x00339C88 File Offset: 0x00337E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueWeeklyBuffs_.CalculateSize(RogueWeeklyInstInfoNotify._repeated_rogueWeeklyBuffs_codec);
			num += this.rogueWeeklyOptions_.CalculateSize(RogueWeeklyInstInfoNotify._map_rogueWeeklyOptions_codec);
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016344 RID: 90948 RVA: 0x00339CEC File Offset: 0x00337EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyInstInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueWeeklyBuffs_.Add(other.rogueWeeklyBuffs_);
			this.rogueWeeklyOptions_.MergeFrom(other.rogueWeeklyOptions_);
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016345 RID: 90949 RVA: 0x00339D4A File Offset: 0x00337F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016346 RID: 90950 RVA: 0x00339D54 File Offset: 0x00337F54
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_45;
					}
					if (num == 106U)
					{
						this.rogueWeeklyOptions_.AddEntriesFrom(ref input, RogueWeeklyInstInfoNotify._map_rogueWeeklyOptions_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.rogueWeeklyBuffs_.AddEntriesFrom(ref input, RogueWeeklyInstInfoNotify._repeated_rogueWeeklyBuffs_codec);
			}
		}

		// Token: 0x040084DC RID: 34012
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084DD RID: 34013
		public const int RogueWeeklyBuffsFieldNumber = 4;

		// Token: 0x040084DE RID: 34014
		private static readonly FieldCodec<int> _repeated_rogueWeeklyBuffs_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040084DF RID: 34015
		private readonly RepeatedField<int> rogueWeeklyBuffs_ = new RepeatedField<int>();

		// Token: 0x040084E0 RID: 34016
		public const int RogueWeeklyOptionsFieldNumber = 13;

		// Token: 0x040084E1 RID: 34017
		private static readonly MapField<int, RogueWeeklyOption>.Codec _map_rogueWeeklyOptions_codec = new MapField<int, RogueWeeklyOption>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<RogueWeeklyOption>(18U, RogueWeeklyOption.Parser), 106U);

		// Token: 0x040084E2 RID: 34018
		private readonly MapField<int, RogueWeeklyOption> rogueWeeklyOptions_ = new MapField<int, RogueWeeklyOption>();

		// Token: 0x040084E3 RID: 34019
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040084E4 RID: 34020
		private int configId_;
	}
}
