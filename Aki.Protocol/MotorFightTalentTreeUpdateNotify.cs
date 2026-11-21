using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5B RID: 2651
	[NetMessage(EMessageId.MotorFightTalentTreeUpdateNotify)]
	public sealed class MotorFightTalentTreeUpdateNotify : IMessage<MotorFightTalentTreeUpdateNotify>, IMessage, IEquatable<MotorFightTalentTreeUpdateNotify>, IDeepCloneable<MotorFightTalentTreeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E79C RID: 59292 RVA: 0x0021DD49 File Offset: 0x0021BF49
		[NullableContext(1)]
		public static MotorFightTalentTreeUpdateNotify Create()
		{
			return new MotorFightTalentTreeUpdateNotify();
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0600E79D RID: 59293 RVA: 0x0021DD50 File Offset: 0x0021BF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x0021DD53 File Offset: 0x0021BF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentTreeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E79F RID: 59295 RVA: 0x0021DD5A File Offset: 0x0021BF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreeUpdateNotify()
		{
		}

		// Token: 0x0600E7A0 RID: 59296 RVA: 0x0021DD6D File Offset: 0x0021BF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreeUpdateNotify(MotorFightTalentTreeUpdateNotify other) : this()
		{
			this.talent_ = other.talent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7A1 RID: 59297 RVA: 0x0021DD97 File Offset: 0x0021BF97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreeUpdateNotify Clone()
		{
			return new MotorFightTalentTreeUpdateNotify(this);
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x0021DD9F File Offset: 0x0021BF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightTalentPb> Talent
		{
			get
			{
				return this.talent_;
			}
		}

		// Token: 0x0600E7A3 RID: 59299 RVA: 0x0021DDA7 File Offset: 0x0021BFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentTreeUpdateNotify);
		}

		// Token: 0x0600E7A4 RID: 59300 RVA: 0x0021DDB5 File Offset: 0x0021BFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentTreeUpdateNotify other)
		{
			return other != null && (other == this || (this.talent_.Equals(other.talent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7A5 RID: 59301 RVA: 0x0021DDE8 File Offset: 0x0021BFE8
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

		// Token: 0x0600E7A6 RID: 59302 RVA: 0x0021DE1C File Offset: 0x0021C01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7A7 RID: 59303 RVA: 0x0021DE29 File Offset: 0x0021C029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x0021DE32 File Offset: 0x0021C032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talent_.WriteTo(ref output, MotorFightTalentTreeUpdateNotify._repeated_talent_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x0021DE5C File Offset: 0x0021C05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.talent_.CalculateSize(MotorFightTalentTreeUpdateNotify._repeated_talent_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7AA RID: 59306 RVA: 0x0021DE95 File Offset: 0x0021C095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentTreeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.talent_.Add(other.talent_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x0021DEC3 File Offset: 0x0021C0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x0021DECC File Offset: 0x0021C0CC
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
					this.talent_.AddEntriesFrom(ref input, MotorFightTalentTreeUpdateNotify._repeated_talent_codec);
				}
			}
		}

		// Token: 0x04005EC6 RID: 24262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EC7 RID: 24263
		public const int TalentFieldNumber = 1;

		// Token: 0x04005EC8 RID: 24264
		private static readonly FieldCodec<MotorFightTalentPb> _repeated_talent_codec = FieldCodec.ForMessage<MotorFightTalentPb>(10U, MotorFightTalentPb.Parser);

		// Token: 0x04005EC9 RID: 24265
		private readonly RepeatedField<MotorFightTalentPb> talent_ = new RepeatedField<MotorFightTalentPb>();
	}
}
