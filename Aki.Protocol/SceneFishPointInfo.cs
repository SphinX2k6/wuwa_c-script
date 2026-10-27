using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200114F RID: 4431
	public sealed class SceneFishPointInfo : IMessage<SceneFishPointInfo>, IMessage, IEquatable<SceneFishPointInfo>, IDeepCloneable<SceneFishPointInfo>, IBufferMessage
	{
		// Token: 0x060179F1 RID: 96753 RVA: 0x0036DD8B File Offset: 0x0036BF8B
		[NullableContext(1)]
		public static SceneFishPointInfo Create()
		{
			return new SceneFishPointInfo();
		}

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x060179F2 RID: 96754 RVA: 0x0036DD92 File Offset: 0x0036BF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneFishPointInfo> Parser
		{
			get
			{
				return SceneFishPointInfo._parser;
			}
		}

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x060179F3 RID: 96755 RVA: 0x0036DD99 File Offset: 0x0036BF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x060179F4 RID: 96756 RVA: 0x0036DD9C File Offset: 0x0036BF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneFishPointInfo.Descriptor;
			}
		}

		// Token: 0x060179F5 RID: 96757 RVA: 0x0036DDA3 File Offset: 0x0036BFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfo()
		{
		}

		// Token: 0x060179F6 RID: 96758 RVA: 0x0036DDC1 File Offset: 0x0036BFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfo(SceneFishPointInfo other) : this()
		{
			this.fishPoints_ = other.fishPoints_.Clone();
			this.tempFishPoints_ = other.tempFishPoints_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179F7 RID: 96759 RVA: 0x0036DDFC File Offset: 0x0036BFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfo Clone()
		{
			return new SceneFishPointInfo(this);
		}

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x060179F8 RID: 96760 RVA: 0x0036DE04 File Offset: 0x0036C004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFishPointInfo> FishPoints
		{
			get
			{
				return this.fishPoints_;
			}
		}

		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x060179F9 RID: 96761 RVA: 0x0036DE0C File Offset: 0x0036C00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TempFishPointInfo> TempFishPoints
		{
			get
			{
				return this.tempFishPoints_;
			}
		}

		// Token: 0x060179FA RID: 96762 RVA: 0x0036DE14 File Offset: 0x0036C014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneFishPointInfo);
		}

		// Token: 0x060179FB RID: 96763 RVA: 0x0036DE24 File Offset: 0x0036C024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneFishPointInfo other)
		{
			return other != null && (other == this || (this.fishPoints_.Equals(other.fishPoints_) && this.tempFishPoints_.Equals(other.tempFishPoints_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179FC RID: 96764 RVA: 0x0036DE78 File Offset: 0x0036C078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fishPoints_.GetHashCode();
			num ^= this.tempFishPoints_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179FD RID: 96765 RVA: 0x0036DEBA File Offset: 0x0036C0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179FE RID: 96766 RVA: 0x0036DEC7 File Offset: 0x0036C0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179FF RID: 96767 RVA: 0x0036DED0 File Offset: 0x0036C0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fishPoints_.WriteTo(ref output, SceneFishPointInfo._repeated_fishPoints_codec);
			this.tempFishPoints_.WriteTo(ref output, SceneFishPointInfo._repeated_tempFishPoints_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017A00 RID: 96768 RVA: 0x0036DF08 File Offset: 0x0036C108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fishPoints_.CalculateSize(SceneFishPointInfo._repeated_fishPoints_codec);
			num += this.tempFishPoints_.CalculateSize(SceneFishPointInfo._repeated_tempFishPoints_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017A01 RID: 96769 RVA: 0x0036DF54 File Offset: 0x0036C154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneFishPointInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.fishPoints_.Add(other.fishPoints_);
			this.tempFishPoints_.Add(other.tempFishPoints_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017A02 RID: 96770 RVA: 0x0036DF93 File Offset: 0x0036C193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017A03 RID: 96771 RVA: 0x0036DF9C File Offset: 0x0036C19C
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tempFishPoints_.AddEntriesFrom(ref input, SceneFishPointInfo._repeated_tempFishPoints_codec);
					}
				}
				else
				{
					this.fishPoints_.AddEntriesFrom(ref input, SceneFishPointInfo._repeated_fishPoints_codec);
				}
			}
		}

		// Token: 0x04008C38 RID: 35896
		private static readonly MessageParser<SceneFishPointInfo> _parser = new MessageParser<SceneFishPointInfo>(() => new SceneFishPointInfo());

		// Token: 0x04008C39 RID: 35897
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008C3A RID: 35898
		public const int FishPointsFieldNumber = 1;

		// Token: 0x04008C3B RID: 35899
		private static readonly FieldCodec<OneFishPointInfo> _repeated_fishPoints_codec = FieldCodec.ForMessage<OneFishPointInfo>(10U, OneFishPointInfo.Parser);

		// Token: 0x04008C3C RID: 35900
		private readonly RepeatedField<OneFishPointInfo> fishPoints_ = new RepeatedField<OneFishPointInfo>();

		// Token: 0x04008C3D RID: 35901
		public const int TempFishPointsFieldNumber = 2;

		// Token: 0x04008C3E RID: 35902
		private static readonly FieldCodec<TempFishPointInfo> _repeated_tempFishPoints_codec = FieldCodec.ForMessage<TempFishPointInfo>(18U, TempFishPointInfo.Parser);

		// Token: 0x04008C3F RID: 35903
		private readonly RepeatedField<TempFishPointInfo> tempFishPoints_ = new RepeatedField<TempFishPointInfo>();
	}
}
