using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6B RID: 2667
	public sealed class MotorFightTalentTreePb : IMessage<MotorFightTalentTreePb>, IMessage, IEquatable<MotorFightTalentTreePb>, IDeepCloneable<MotorFightTalentTreePb>, IBufferMessage
	{
		// Token: 0x0600E8A4 RID: 59556 RVA: 0x0021FD5A File Offset: 0x0021DF5A
		[NullableContext(1)]
		public static MotorFightTalentTreePb Create()
		{
			return new MotorFightTalentTreePb();
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x0600E8A5 RID: 59557 RVA: 0x0021FD61 File Offset: 0x0021DF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x0021FD64 File Offset: 0x0021DF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentTreePb.Descriptor;
			}
		}

		// Token: 0x0600E8A7 RID: 59559 RVA: 0x0021FD6B File Offset: 0x0021DF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreePb()
		{
		}

		// Token: 0x0600E8A8 RID: 59560 RVA: 0x0021FD7E File Offset: 0x0021DF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreePb(MotorFightTalentTreePb other) : this()
		{
			this.talent_ = other.talent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8A9 RID: 59561 RVA: 0x0021FDA8 File Offset: 0x0021DFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreePb Clone()
		{
			return new MotorFightTalentTreePb(this);
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0600E8AA RID: 59562 RVA: 0x0021FDB0 File Offset: 0x0021DFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightTalentPb> Talent
		{
			get
			{
				return this.talent_;
			}
		}

		// Token: 0x0600E8AB RID: 59563 RVA: 0x0021FDB8 File Offset: 0x0021DFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentTreePb);
		}

		// Token: 0x0600E8AC RID: 59564 RVA: 0x0021FDC6 File Offset: 0x0021DFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentTreePb other)
		{
			return other != null && (other == this || (this.talent_.Equals(other.talent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8AD RID: 59565 RVA: 0x0021FDFC File Offset: 0x0021DFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.talent_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E8AE RID: 59566 RVA: 0x0021FE30 File Offset: 0x0021E030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8AF RID: 59567 RVA: 0x0021FE3D File Offset: 0x0021E03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8B0 RID: 59568 RVA: 0x0021FE46 File Offset: 0x0021E046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talent_.WriteTo(ref output, MotorFightTalentTreePb._repeated_talent_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E8B1 RID: 59569 RVA: 0x0021FE70 File Offset: 0x0021E070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.talent_.CalculateSize(MotorFightTalentTreePb._repeated_talent_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x0021FEA9 File Offset: 0x0021E0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentTreePb other)
		{
			if (other == null)
			{
				return;
			}
			this.talent_.Add(other.talent_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E8B3 RID: 59571 RVA: 0x0021FED7 File Offset: 0x0021E0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8B4 RID: 59572 RVA: 0x0021FEE0 File Offset: 0x0021E0E0
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
					this.talent_.AddEntriesFrom(ref input, MotorFightTalentTreePb._repeated_talent_codec);
				}
			}
		}

		// Token: 0x04005EB9 RID: 24249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EBA RID: 24250
		public const int TalentFieldNumber = 1;

		// Token: 0x04005EBB RID: 24251
		private static readonly FieldCodec<MotorFightTalentPb> _repeated_talent_codec = FieldCodec.ForMessage<MotorFightTalentPb>(10U, MotorFightTalentPb.Parser);

		// Token: 0x04005EBC RID: 24252
		private readonly RepeatedField<MotorFightTalentPb> talent_ = new RepeatedField<MotorFightTalentPb>();
	}
}
