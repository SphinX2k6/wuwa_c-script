using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A7 RID: 4775
	public sealed class SolarSchoolCharacterDataPb : IMessage<SolarSchoolCharacterDataPb>, IMessage, IEquatable<SolarSchoolCharacterDataPb>, IDeepCloneable<SolarSchoolCharacterDataPb>, IBufferMessage
	{
		// Token: 0x060197D6 RID: 104406 RVA: 0x003B8070 File Offset: 0x003B6270
		[NullableContext(1)]
		public static SolarSchoolCharacterDataPb Create()
		{
			return new SolarSchoolCharacterDataPb();
		}

		// Token: 0x17005643 RID: 22083
		// (get) Token: 0x060197D7 RID: 104407 RVA: 0x003B8077 File Offset: 0x003B6277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005644 RID: 22084
		// (get) Token: 0x060197D8 RID: 104408 RVA: 0x003B807A File Offset: 0x003B627A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolCharacterDataPb.Descriptor;
			}
		}

		// Token: 0x060197D9 RID: 104409 RVA: 0x003B8081 File Offset: 0x003B6281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolCharacterDataPb()
		{
		}

		// Token: 0x060197DA RID: 104410 RVA: 0x003B8094 File Offset: 0x003B6294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolCharacterDataPb(SolarSchoolCharacterDataPb other) : this()
		{
			this.npc_ = other.npc_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060197DB RID: 104411 RVA: 0x003B80BE File Offset: 0x003B62BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolCharacterDataPb Clone()
		{
			return new SolarSchoolCharacterDataPb(this);
		}

		// Token: 0x17005645 RID: 22085
		// (get) Token: 0x060197DC RID: 104412 RVA: 0x003B80C6 File Offset: 0x003B62C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolNpcPb> Npc
		{
			get
			{
				return this.npc_;
			}
		}

		// Token: 0x060197DD RID: 104413 RVA: 0x003B80CE File Offset: 0x003B62CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolCharacterDataPb);
		}

		// Token: 0x060197DE RID: 104414 RVA: 0x003B80DC File Offset: 0x003B62DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolCharacterDataPb other)
		{
			return other != null && (other == this || (this.npc_.Equals(other.npc_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197DF RID: 104415 RVA: 0x003B8110 File Offset: 0x003B6310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.npc_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060197E0 RID: 104416 RVA: 0x003B8144 File Offset: 0x003B6344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197E1 RID: 104417 RVA: 0x003B8151 File Offset: 0x003B6351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197E2 RID: 104418 RVA: 0x003B815A File Offset: 0x003B635A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.npc_.WriteTo(ref output, SolarSchoolCharacterDataPb._repeated_npc_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197E3 RID: 104419 RVA: 0x003B8184 File Offset: 0x003B6384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npc_.CalculateSize(SolarSchoolCharacterDataPb._repeated_npc_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060197E4 RID: 104420 RVA: 0x003B81BD File Offset: 0x003B63BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolCharacterDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.npc_.Add(other.npc_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060197E5 RID: 104421 RVA: 0x003B81EB File Offset: 0x003B63EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197E6 RID: 104422 RVA: 0x003B81F4 File Offset: 0x003B63F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.npc_.AddEntriesFrom(ref input, SolarSchoolCharacterDataPb._repeated_npc_codec);
				}
			}
		}

		// Token: 0x040096AA RID: 38570
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096AB RID: 38571
		public const int NpcFieldNumber = 1;

		// Token: 0x040096AC RID: 38572
		private static readonly FieldCodec<SolarSchoolNpcPb> _repeated_npc_codec = FieldCodec.ForMessage<SolarSchoolNpcPb>(10U, SolarSchoolNpcPb.Parser);

		// Token: 0x040096AD RID: 38573
		private readonly RepeatedField<SolarSchoolNpcPb> npc_ = new RepeatedField<SolarSchoolNpcPb>();
	}
}
