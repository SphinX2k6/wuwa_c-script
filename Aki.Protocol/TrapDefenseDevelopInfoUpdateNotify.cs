using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001420 RID: 5152
	[NetMessage(EMessageId.TrapDefenseDevelopInfoUpdateNotify)]
	public sealed class TrapDefenseDevelopInfoUpdateNotify : IMessage<TrapDefenseDevelopInfoUpdateNotify>, IMessage, IEquatable<TrapDefenseDevelopInfoUpdateNotify>, IDeepCloneable<TrapDefenseDevelopInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B4E8 RID: 111848 RVA: 0x003F4EE0 File Offset: 0x003F30E0
		[NullableContext(1)]
		public static TrapDefenseDevelopInfoUpdateNotify Create()
		{
			return new TrapDefenseDevelopInfoUpdateNotify();
		}

		// Token: 0x17005C1C RID: 23580
		// (get) Token: 0x0601B4E9 RID: 111849 RVA: 0x003F4EE7 File Offset: 0x003F30E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C1D RID: 23581
		// (get) Token: 0x0601B4EA RID: 111850 RVA: 0x003F4EEA File Offset: 0x003F30EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseDevelopInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B4EB RID: 111851 RVA: 0x003F4EF1 File Offset: 0x003F30F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopInfoUpdateNotify()
		{
		}

		// Token: 0x0601B4EC RID: 111852 RVA: 0x003F4F0F File Offset: 0x003F310F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopInfoUpdateNotify(TrapDefenseDevelopInfoUpdateNotify other) : this()
		{
			this.auxiliaries_ = other.auxiliaries_.Clone();
			this.buildings_ = other.buildings_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4ED RID: 111853 RVA: 0x003F4F4A File Offset: 0x003F314A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopInfoUpdateNotify Clone()
		{
			return new TrapDefenseDevelopInfoUpdateNotify(this);
		}

		// Token: 0x17005C1E RID: 23582
		// (get) Token: 0x0601B4EE RID: 111854 RVA: 0x003F4F52 File Offset: 0x003F3152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseAuxiliaryInfo> Auxiliaries
		{
			get
			{
				return this.auxiliaries_;
			}
		}

		// Token: 0x17005C1F RID: 23583
		// (get) Token: 0x0601B4EF RID: 111855 RVA: 0x003F4F5A File Offset: 0x003F315A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseBuildingInfo> Buildings
		{
			get
			{
				return this.buildings_;
			}
		}

		// Token: 0x0601B4F0 RID: 111856 RVA: 0x003F4F62 File Offset: 0x003F3162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseDevelopInfoUpdateNotify);
		}

		// Token: 0x0601B4F1 RID: 111857 RVA: 0x003F4F70 File Offset: 0x003F3170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseDevelopInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.auxiliaries_.Equals(other.auxiliaries_) && this.buildings_.Equals(other.buildings_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B4F2 RID: 111858 RVA: 0x003F4FC4 File Offset: 0x003F31C4
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

		// Token: 0x0601B4F3 RID: 111859 RVA: 0x003F5006 File Offset: 0x003F3206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4F4 RID: 111860 RVA: 0x003F5013 File Offset: 0x003F3213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4F5 RID: 111861 RVA: 0x003F501C File Offset: 0x003F321C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.auxiliaries_.WriteTo(ref output, TrapDefenseDevelopInfoUpdateNotify._repeated_auxiliaries_codec);
			this.buildings_.WriteTo(ref output, TrapDefenseDevelopInfoUpdateNotify._repeated_buildings_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4F6 RID: 111862 RVA: 0x003F5054 File Offset: 0x003F3254
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

		// Token: 0x0601B4F7 RID: 111863 RVA: 0x003F50A0 File Offset: 0x003F32A0
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

		// Token: 0x0601B4F8 RID: 111864 RVA: 0x003F50DF File Offset: 0x003F32DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4F9 RID: 111865 RVA: 0x003F50E8 File Offset: 0x003F32E8
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buildings_.AddEntriesFrom(ref input, TrapDefenseDevelopInfoUpdateNotify._repeated_buildings_codec);
					}
				}
				else
				{
					this.auxiliaries_.AddEntriesFrom(ref input, TrapDefenseDevelopInfoUpdateNotify._repeated_auxiliaries_codec);
				}
			}
		}

		// Token: 0x04009DD3 RID: 40403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DD4 RID: 40404
		public const int AuxiliariesFieldNumber = 2;

		// Token: 0x04009DD5 RID: 40405
		private static readonly FieldCodec<TrapDefenseAuxiliaryInfo> _repeated_auxiliaries_codec = FieldCodec.ForMessage<TrapDefenseAuxiliaryInfo>(18U, TrapDefenseAuxiliaryInfo.Parser);

		// Token: 0x04009DD6 RID: 40406
		private readonly RepeatedField<TrapDefenseAuxiliaryInfo> auxiliaries_ = new RepeatedField<TrapDefenseAuxiliaryInfo>();

		// Token: 0x04009DD7 RID: 40407
		public const int BuildingsFieldNumber = 11;

		// Token: 0x04009DD8 RID: 40408
		private static readonly FieldCodec<TrapDefenseBuildingInfo> _repeated_buildings_codec = FieldCodec.ForMessage<TrapDefenseBuildingInfo>(90U, TrapDefenseBuildingInfo.Parser);

		// Token: 0x04009DD9 RID: 40409
		private readonly RepeatedField<TrapDefenseBuildingInfo> buildings_ = new RepeatedField<TrapDefenseBuildingInfo>();
	}
}
