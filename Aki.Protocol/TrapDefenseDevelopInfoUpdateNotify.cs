using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001493 RID: 5267
	[NetMessage(EMessageId.TrapDefenseDevelopInfoUpdateNotify)]
	public sealed class TrapDefenseDevelopInfoUpdateNotify : IMessage<TrapDefenseDevelopInfoUpdateNotify>, IMessage, IEquatable<TrapDefenseDevelopInfoUpdateNotify>, IDeepCloneable<TrapDefenseDevelopInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601BF73 RID: 114547 RVA: 0x004101B4 File Offset: 0x0040E3B4
		[NullableContext(1)]
		public static TrapDefenseDevelopInfoUpdateNotify Create()
		{
			return new TrapDefenseDevelopInfoUpdateNotify();
		}

		// Token: 0x17005EB1 RID: 24241
		// (get) Token: 0x0601BF74 RID: 114548 RVA: 0x004101BB File Offset: 0x0040E3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EB2 RID: 24242
		// (get) Token: 0x0601BF75 RID: 114549 RVA: 0x004101BE File Offset: 0x0040E3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseDevelopInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601BF76 RID: 114550 RVA: 0x004101C5 File Offset: 0x0040E3C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopInfoUpdateNotify()
		{
		}

		// Token: 0x0601BF77 RID: 114551 RVA: 0x004101E3 File Offset: 0x0040E3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopInfoUpdateNotify(TrapDefenseDevelopInfoUpdateNotify other) : this()
		{
			this.auxiliaries_ = other.auxiliaries_.Clone();
			this.buildings_ = other.buildings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF78 RID: 114552 RVA: 0x0041021E File Offset: 0x0040E41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopInfoUpdateNotify Clone()
		{
			return new TrapDefenseDevelopInfoUpdateNotify(this);
		}

		// Token: 0x17005EB3 RID: 24243
		// (get) Token: 0x0601BF79 RID: 114553 RVA: 0x00410226 File Offset: 0x0040E426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseAuxiliaryInfo> Auxiliaries
		{
			get
			{
				return this.auxiliaries_;
			}
		}

		// Token: 0x17005EB4 RID: 24244
		// (get) Token: 0x0601BF7A RID: 114554 RVA: 0x0041022E File Offset: 0x0040E42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseBuildingInfo> Buildings
		{
			get
			{
				return this.buildings_;
			}
		}

		// Token: 0x0601BF7B RID: 114555 RVA: 0x00410236 File Offset: 0x0040E436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseDevelopInfoUpdateNotify);
		}

		// Token: 0x0601BF7C RID: 114556 RVA: 0x00410244 File Offset: 0x0040E444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseDevelopInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.auxiliaries_.Equals(other.auxiliaries_) && this.buildings_.Equals(other.buildings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF7D RID: 114557 RVA: 0x00410298 File Offset: 0x0040E498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.auxiliaries_.GetHashCode();
			num ^= this.buildings_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF7E RID: 114558 RVA: 0x004102DA File Offset: 0x0040E4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF7F RID: 114559 RVA: 0x004102E7 File Offset: 0x0040E4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF80 RID: 114560 RVA: 0x004102F0 File Offset: 0x0040E4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buildings_.WriteTo(ref output, TrapDefenseDevelopInfoUpdateNotify._repeated_buildings_codec);
			this.auxiliaries_.WriteTo(ref output, TrapDefenseDevelopInfoUpdateNotify._repeated_auxiliaries_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF81 RID: 114561 RVA: 0x00410328 File Offset: 0x0040E528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.auxiliaries_.CalculateSize(TrapDefenseDevelopInfoUpdateNotify._repeated_auxiliaries_codec);
			num += this.buildings_.CalculateSize(TrapDefenseDevelopInfoUpdateNotify._repeated_buildings_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF82 RID: 114562 RVA: 0x00410374 File Offset: 0x0040E574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseDevelopInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.auxiliaries_.Add(other.auxiliaries_);
			this.buildings_.Add(other.buildings_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF83 RID: 114563 RVA: 0x004103B3 File Offset: 0x0040E5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF84 RID: 114564 RVA: 0x004103BC File Offset: 0x0040E5BC
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
				if (num != 18U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.auxiliaries_.AddEntriesFrom(ref input, TrapDefenseDevelopInfoUpdateNotify._repeated_auxiliaries_codec);
					}
				}
				else
				{
					this.buildings_.AddEntriesFrom(ref input, TrapDefenseDevelopInfoUpdateNotify._repeated_buildings_codec);
				}
			}
		}

		// Token: 0x0400A21A RID: 41498
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A21B RID: 41499
		public const int AuxiliariesFieldNumber = 10;

		// Token: 0x0400A21C RID: 41500
		private static readonly FieldCodec<TrapDefenseAuxiliaryInfo> _repeated_auxiliaries_codec = FieldCodec.ForMessage<TrapDefenseAuxiliaryInfo>(82U, TrapDefenseAuxiliaryInfo.Parser);

		// Token: 0x0400A21D RID: 41501
		private readonly RepeatedField<TrapDefenseAuxiliaryInfo> auxiliaries_ = new RepeatedField<TrapDefenseAuxiliaryInfo>();

		// Token: 0x0400A21E RID: 41502
		public const int BuildingsFieldNumber = 2;

		// Token: 0x0400A21F RID: 41503
		private static readonly FieldCodec<TrapDefenseBuildingInfo> _repeated_buildings_codec = FieldCodec.ForMessage<TrapDefenseBuildingInfo>(18U, TrapDefenseBuildingInfo.Parser);

		// Token: 0x0400A220 RID: 41504
		private readonly RepeatedField<TrapDefenseBuildingInfo> buildings_ = new RepeatedField<TrapDefenseBuildingInfo>();
	}
}
