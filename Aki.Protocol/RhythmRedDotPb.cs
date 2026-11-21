using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F33 RID: 3891
	public sealed class RhythmRedDotPb : IMessage<RhythmRedDotPb>, IMessage, IEquatable<RhythmRedDotPb>, IDeepCloneable<RhythmRedDotPb>, IBufferMessage
	{
		// Token: 0x06014D8A RID: 85386 RVA: 0x00306C23 File Offset: 0x00304E23
		[NullableContext(1)]
		public static RhythmRedDotPb Create()
		{
			return new RhythmRedDotPb();
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x06014D8B RID: 85387 RVA: 0x00306C2A File Offset: 0x00304E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x06014D8C RID: 85388 RVA: 0x00306C2D File Offset: 0x00304E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRedDotPb.Descriptor;
			}
		}

		// Token: 0x06014D8D RID: 85389 RVA: 0x00306C34 File Offset: 0x00304E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb()
		{
		}

		// Token: 0x06014D8E RID: 85390 RVA: 0x00306C60 File Offset: 0x00304E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb(RhythmRedDotPb other) : this()
		{
			this.readPlanet_ = other.readPlanet_.Clone();
			this.readSubLevel_ = other.readSubLevel_.Clone();
			this.readRole_ = other.readRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D8F RID: 85391 RVA: 0x00306CB7 File Offset: 0x00304EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb Clone()
		{
			return new RhythmRedDotPb(this);
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x06014D90 RID: 85392 RVA: 0x00306CBF File Offset: 0x00304EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadPlanet
		{
			get
			{
				return this.readPlanet_;
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x06014D91 RID: 85393 RVA: 0x00306CC7 File Offset: 0x00304EC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadSubLevel
		{
			get
			{
				return this.readSubLevel_;
			}
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x06014D92 RID: 85394 RVA: 0x00306CCF File Offset: 0x00304ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadRole
		{
			get
			{
				return this.readRole_;
			}
		}

		// Token: 0x06014D93 RID: 85395 RVA: 0x00306CD7 File Offset: 0x00304ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRedDotPb);
		}

		// Token: 0x06014D94 RID: 85396 RVA: 0x00306CE8 File Offset: 0x00304EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRedDotPb other)
		{
			return other != null && (other == this || (this.readPlanet_.Equals(other.readPlanet_) && this.readSubLevel_.Equals(other.readSubLevel_) && this.readRole_.Equals(other.readRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D95 RID: 85397 RVA: 0x00306D50 File Offset: 0x00304F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.readPlanet_.GetHashCode();
			num ^= this.readSubLevel_.GetHashCode();
			num ^= this.readRole_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014D96 RID: 85398 RVA: 0x00306DA0 File Offset: 0x00304FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D97 RID: 85399 RVA: 0x00306DAD File Offset: 0x00304FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D98 RID: 85400 RVA: 0x00306DB8 File Offset: 0x00304FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.readPlanet_.WriteTo(ref output, RhythmRedDotPb._repeated_readPlanet_codec);
			this.readSubLevel_.WriteTo(ref output, RhythmRedDotPb._repeated_readSubLevel_codec);
			this.readRole_.WriteTo(ref output, RhythmRedDotPb._repeated_readRole_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D99 RID: 85401 RVA: 0x00306E0C File Offset: 0x0030500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.readPlanet_.CalculateSize(RhythmRedDotPb._repeated_readPlanet_codec);
			num += this.readSubLevel_.CalculateSize(RhythmRedDotPb._repeated_readSubLevel_codec);
			num += this.readRole_.CalculateSize(RhythmRedDotPb._repeated_readRole_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014D9A RID: 85402 RVA: 0x00306E6C File Offset: 0x0030506C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRedDotPb other)
		{
			if (other == null)
			{
				return;
			}
			this.readPlanet_.Add(other.readPlanet_);
			this.readSubLevel_.Add(other.readSubLevel_);
			this.readRole_.Add(other.readRole_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014D9B RID: 85403 RVA: 0x00306EC7 File Offset: 0x003050C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D9C RID: 85404 RVA: 0x00306ED0 File Offset: 0x003050D0
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
					if (num == 16U || num == 18U)
					{
						this.readPlanet_.AddEntriesFrom(ref input, RhythmRedDotPb._repeated_readPlanet_codec);
						continue;
					}
					if (num == 32U)
					{
						goto IL_55;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_55;
					}
					if (num == 40U || num == 42U)
					{
						this.readRole_.AddEntriesFrom(ref input, RhythmRedDotPb._repeated_readRole_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_55:
				this.readSubLevel_.AddEntriesFrom(ref input, RhythmRedDotPb._repeated_readSubLevel_codec);
			}
		}

		// Token: 0x04007E32 RID: 32306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E33 RID: 32307
		public const int ReadPlanetFieldNumber = 2;

		// Token: 0x04007E34 RID: 32308
		private static readonly FieldCodec<int> _repeated_readPlanet_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007E35 RID: 32309
		private readonly RepeatedField<int> readPlanet_ = new RepeatedField<int>();

		// Token: 0x04007E36 RID: 32310
		public const int ReadSubLevelFieldNumber = 4;

		// Token: 0x04007E37 RID: 32311
		private static readonly FieldCodec<int> _repeated_readSubLevel_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007E38 RID: 32312
		private readonly RepeatedField<int> readSubLevel_ = new RepeatedField<int>();

		// Token: 0x04007E39 RID: 32313
		public const int ReadRoleFieldNumber = 5;

		// Token: 0x04007E3A RID: 32314
		private static readonly FieldCodec<int> _repeated_readRole_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007E3B RID: 32315
		private readonly RepeatedField<int> readRole_ = new RepeatedField<int>();
	}
}
