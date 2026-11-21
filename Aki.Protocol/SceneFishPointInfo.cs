using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001189 RID: 4489
	public sealed class SceneFishPointInfo : IMessage<SceneFishPointInfo>, IMessage, IEquatable<SceneFishPointInfo>, IDeepCloneable<SceneFishPointInfo>, IBufferMessage
	{
		// Token: 0x06017F92 RID: 98194 RVA: 0x0037D0D7 File Offset: 0x0037B2D7
		[NullableContext(1)]
		public static SceneFishPointInfo Create()
		{
			return new SceneFishPointInfo();
		}

		// Token: 0x170050B2 RID: 20658
		// (get) Token: 0x06017F93 RID: 98195 RVA: 0x0037D0DE File Offset: 0x0037B2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneFishPointInfo> Parser
		{
			get
			{
				return SceneFishPointInfo._parser;
			}
		}

		// Token: 0x170050B3 RID: 20659
		// (get) Token: 0x06017F94 RID: 98196 RVA: 0x0037D0E5 File Offset: 0x0037B2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050B4 RID: 20660
		// (get) Token: 0x06017F95 RID: 98197 RVA: 0x0037D0E8 File Offset: 0x0037B2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneFishPointInfo.Descriptor;
			}
		}

		// Token: 0x06017F96 RID: 98198 RVA: 0x0037D0EF File Offset: 0x0037B2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfo()
		{
		}

		// Token: 0x06017F97 RID: 98199 RVA: 0x0037D10D File Offset: 0x0037B30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfo(SceneFishPointInfo other) : this()
		{
			this.fishPoints_ = other.fishPoints_.Clone();
			this.tempFishPoints_ = other.tempFishPoints_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F98 RID: 98200 RVA: 0x0037D148 File Offset: 0x0037B348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneFishPointInfo Clone()
		{
			return new SceneFishPointInfo(this);
		}

		// Token: 0x170050B5 RID: 20661
		// (get) Token: 0x06017F99 RID: 98201 RVA: 0x0037D150 File Offset: 0x0037B350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFishPointInfo> FishPoints
		{
			get
			{
				return this.fishPoints_;
			}
		}

		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x06017F9A RID: 98202 RVA: 0x0037D158 File Offset: 0x0037B358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TempFishPointInfo> TempFishPoints
		{
			get
			{
				return this.tempFishPoints_;
			}
		}

		// Token: 0x06017F9B RID: 98203 RVA: 0x0037D160 File Offset: 0x0037B360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneFishPointInfo);
		}

		// Token: 0x06017F9C RID: 98204 RVA: 0x0037D170 File Offset: 0x0037B370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneFishPointInfo other)
		{
			return other != null && (other == this || (this.fishPoints_.Equals(other.fishPoints_) && this.tempFishPoints_.Equals(other.tempFishPoints_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F9D RID: 98205 RVA: 0x0037D1C4 File Offset: 0x0037B3C4
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

		// Token: 0x06017F9E RID: 98206 RVA: 0x0037D206 File Offset: 0x0037B406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F9F RID: 98207 RVA: 0x0037D213 File Offset: 0x0037B413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FA0 RID: 98208 RVA: 0x0037D21C File Offset: 0x0037B41C
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

		// Token: 0x06017FA1 RID: 98209 RVA: 0x0037D254 File Offset: 0x0037B454
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

		// Token: 0x06017FA2 RID: 98210 RVA: 0x0037D2A0 File Offset: 0x0037B4A0
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

		// Token: 0x06017FA3 RID: 98211 RVA: 0x0037D2DF File Offset: 0x0037B4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FA4 RID: 98212 RVA: 0x0037D2E8 File Offset: 0x0037B4E8
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

		// Token: 0x04008ECB RID: 36555
		private static readonly MessageParser<SceneFishPointInfo> _parser = new MessageParser<SceneFishPointInfo>(() => new SceneFishPointInfo());

		// Token: 0x04008ECC RID: 36556
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ECD RID: 36557
		public const int FishPointsFieldNumber = 1;

		// Token: 0x04008ECE RID: 36558
		private static readonly FieldCodec<OneFishPointInfo> _repeated_fishPoints_codec = FieldCodec.ForMessage<OneFishPointInfo>(10U, OneFishPointInfo.Parser);

		// Token: 0x04008ECF RID: 36559
		private readonly RepeatedField<OneFishPointInfo> fishPoints_ = new RepeatedField<OneFishPointInfo>();

		// Token: 0x04008ED0 RID: 36560
		public const int TempFishPointsFieldNumber = 2;

		// Token: 0x04008ED1 RID: 36561
		private static readonly FieldCodec<TempFishPointInfo> _repeated_tempFishPoints_codec = FieldCodec.ForMessage<TempFishPointInfo>(18U, TempFishPointInfo.Parser);

		// Token: 0x04008ED2 RID: 36562
		private readonly RepeatedField<TempFishPointInfo> tempFishPoints_ = new RepeatedField<TempFishPointInfo>();
	}
}
