using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F43 RID: 3907
	public sealed class RhythmRedDotPb : IMessage<RhythmRedDotPb>, IMessage, IEquatable<RhythmRedDotPb>, IDeepCloneable<RhythmRedDotPb>, IBufferMessage
	{
		// Token: 0x06014E6F RID: 85615 RVA: 0x003082DF File Offset: 0x003064DF
		[NullableContext(1)]
		public static RhythmRedDotPb Create()
		{
			return new RhythmRedDotPb();
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x06014E70 RID: 85616 RVA: 0x003082E6 File Offset: 0x003064E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x06014E71 RID: 85617 RVA: 0x003082E9 File Offset: 0x003064E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRedDotPb.Descriptor;
			}
		}

		// Token: 0x06014E72 RID: 85618 RVA: 0x003082F0 File Offset: 0x003064F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb()
		{
		}

		// Token: 0x06014E73 RID: 85619 RVA: 0x0030831C File Offset: 0x0030651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb(RhythmRedDotPb other) : this()
		{
			this.readPlanet_ = other.readPlanet_.Clone();
			this.readSubLevel_ = other.readSubLevel_.Clone();
			this.readRole_ = other.readRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E74 RID: 85620 RVA: 0x00308373 File Offset: 0x00306573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRedDotPb Clone()
		{
			return new RhythmRedDotPb(this);
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x06014E75 RID: 85621 RVA: 0x0030837B File Offset: 0x0030657B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadPlanet
		{
			get
			{
				return this.readPlanet_;
			}
		}

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x06014E76 RID: 85622 RVA: 0x00308383 File Offset: 0x00306583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadSubLevel
		{
			get
			{
				return this.readSubLevel_;
			}
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x06014E77 RID: 85623 RVA: 0x0030838B File Offset: 0x0030658B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadRole
		{
			get
			{
				return this.readRole_;
			}
		}

		// Token: 0x06014E78 RID: 85624 RVA: 0x00308393 File Offset: 0x00306593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRedDotPb);
		}

		// Token: 0x06014E79 RID: 85625 RVA: 0x003083A4 File Offset: 0x003065A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRedDotPb other)
		{
			return other != null && (other == this || (this.readPlanet_.Equals(other.readPlanet_) && this.readSubLevel_.Equals(other.readSubLevel_) && this.readRole_.Equals(other.readRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E7A RID: 85626 RVA: 0x0030840C File Offset: 0x0030660C
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

		// Token: 0x06014E7B RID: 85627 RVA: 0x0030845C File Offset: 0x0030665C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E7C RID: 85628 RVA: 0x00308469 File Offset: 0x00306669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E7D RID: 85629 RVA: 0x00308474 File Offset: 0x00306674
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

		// Token: 0x06014E7E RID: 85630 RVA: 0x003084C8 File Offset: 0x003066C8
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

		// Token: 0x06014E7F RID: 85631 RVA: 0x00308528 File Offset: 0x00306728
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

		// Token: 0x06014E80 RID: 85632 RVA: 0x00308583 File Offset: 0x00306783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E81 RID: 85633 RVA: 0x0030858C File Offset: 0x0030678C
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

		// Token: 0x04007E08 RID: 32264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E09 RID: 32265
		public const int ReadPlanetFieldNumber = 2;

		// Token: 0x04007E0A RID: 32266
		private static readonly FieldCodec<int> _repeated_readPlanet_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007E0B RID: 32267
		private readonly RepeatedField<int> readPlanet_ = new RepeatedField<int>();

		// Token: 0x04007E0C RID: 32268
		public const int ReadSubLevelFieldNumber = 4;

		// Token: 0x04007E0D RID: 32269
		private static readonly FieldCodec<int> _repeated_readSubLevel_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007E0E RID: 32270
		private readonly RepeatedField<int> readSubLevel_ = new RepeatedField<int>();

		// Token: 0x04007E0F RID: 32271
		public const int ReadRoleFieldNumber = 5;

		// Token: 0x04007E10 RID: 32272
		private static readonly FieldCodec<int> _repeated_readRole_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007E11 RID: 32273
		private readonly RepeatedField<int> readRole_ = new RepeatedField<int>();
	}
}
