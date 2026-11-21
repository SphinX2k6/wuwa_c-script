using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5A RID: 2650
	public sealed class MotorFightTalentTreePb : IMessage<MotorFightTalentTreePb>, IMessage, IEquatable<MotorFightTalentTreePb>, IDeepCloneable<MotorFightTalentTreePb>, IBufferMessage
	{
		// Token: 0x0600E78A RID: 59274 RVA: 0x0021DB66 File Offset: 0x0021BD66
		[NullableContext(1)]
		public static MotorFightTalentTreePb Create()
		{
			return new MotorFightTalentTreePb();
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600E78B RID: 59275 RVA: 0x0021DB6D File Offset: 0x0021BD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0600E78C RID: 59276 RVA: 0x0021DB70 File Offset: 0x0021BD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentTreePb.Descriptor;
			}
		}

		// Token: 0x0600E78D RID: 59277 RVA: 0x0021DB77 File Offset: 0x0021BD77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreePb()
		{
		}

		// Token: 0x0600E78E RID: 59278 RVA: 0x0021DB8A File Offset: 0x0021BD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreePb(MotorFightTalentTreePb other) : this()
		{
			this.talent_ = other.talent_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E78F RID: 59279 RVA: 0x0021DBB4 File Offset: 0x0021BDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentTreePb Clone()
		{
			return new MotorFightTalentTreePb(this);
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0600E790 RID: 59280 RVA: 0x0021DBBC File Offset: 0x0021BDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorFightTalentPb> Talent
		{
			get
			{
				return this.talent_;
			}
		}

		// Token: 0x0600E791 RID: 59281 RVA: 0x0021DBC4 File Offset: 0x0021BDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentTreePb);
		}

		// Token: 0x0600E792 RID: 59282 RVA: 0x0021DBD2 File Offset: 0x0021BDD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentTreePb other)
		{
			return other != null && (other == this || (this.talent_.Equals(other.talent_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x0021DC08 File Offset: 0x0021BE08
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

		// Token: 0x0600E794 RID: 59284 RVA: 0x0021DC3C File Offset: 0x0021BE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E795 RID: 59285 RVA: 0x0021DC49 File Offset: 0x0021BE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E796 RID: 59286 RVA: 0x0021DC52 File Offset: 0x0021BE52
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

		// Token: 0x0600E797 RID: 59287 RVA: 0x0021DC7C File Offset: 0x0021BE7C
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

		// Token: 0x0600E798 RID: 59288 RVA: 0x0021DCB5 File Offset: 0x0021BEB5
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

		// Token: 0x0600E799 RID: 59289 RVA: 0x0021DCE3 File Offset: 0x0021BEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E79A RID: 59290 RVA: 0x0021DCEC File Offset: 0x0021BEEC
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

		// Token: 0x04005EC2 RID: 24258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EC3 RID: 24259
		public const int TalentFieldNumber = 1;

		// Token: 0x04005EC4 RID: 24260
		private static readonly FieldCodec<MotorFightTalentPb> _repeated_talent_codec = FieldCodec.ForMessage<MotorFightTalentPb>(10U, MotorFightTalentPb.Parser);

		// Token: 0x04005EC5 RID: 24261
		private readonly RepeatedField<MotorFightTalentPb> talent_ = new RepeatedField<MotorFightTalentPb>();
	}
}
