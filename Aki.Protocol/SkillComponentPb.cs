using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001274 RID: 4724
	public sealed class SkillComponentPb : IMessage<SkillComponentPb>, IMessage, IEquatable<SkillComponentPb>, IDeepCloneable<SkillComponentPb>, IBufferMessage
	{
		// Token: 0x06019382 RID: 103298 RVA: 0x003AD9F9 File Offset: 0x003ABBF9
		[NullableContext(1)]
		public static SkillComponentPb Create()
		{
			return new SkillComponentPb();
		}

		// Token: 0x17005546 RID: 21830
		// (get) Token: 0x06019383 RID: 103299 RVA: 0x003ADA00 File Offset: 0x003ABC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005547 RID: 21831
		// (get) Token: 0x06019384 RID: 103300 RVA: 0x003ADA03 File Offset: 0x003ABC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillComponentPb.Descriptor;
			}
		}

		// Token: 0x06019385 RID: 103301 RVA: 0x003ADA0A File Offset: 0x003ABC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillComponentPb()
		{
		}

		// Token: 0x06019386 RID: 103302 RVA: 0x003ADA28 File Offset: 0x003ABC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillComponentPb(SkillComponentPb other) : this()
		{
			this.skillInfoList_ = other.skillInfoList_.Clone();
			this.gaPassiveSkills_ = other.gaPassiveSkills_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019387 RID: 103303 RVA: 0x003ADA63 File Offset: 0x003ABC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillComponentPb Clone()
		{
			return new SkillComponentPb(this);
		}

		// Token: 0x17005548 RID: 21832
		// (get) Token: 0x06019388 RID: 103304 RVA: 0x003ADA6B File Offset: 0x003ABC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkillExecuteInfoPb> SkillInfoList
		{
			get
			{
				return this.skillInfoList_;
			}
		}

		// Token: 0x17005549 RID: 21833
		// (get) Token: 0x06019389 RID: 103305 RVA: 0x003ADA73 File Offset: 0x003ABC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GaPassiveSkill> GaPassiveSkills
		{
			get
			{
				return this.gaPassiveSkills_;
			}
		}

		// Token: 0x0601938A RID: 103306 RVA: 0x003ADA7B File Offset: 0x003ABC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillComponentPb);
		}

		// Token: 0x0601938B RID: 103307 RVA: 0x003ADA8C File Offset: 0x003ABC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillComponentPb other)
		{
			return other != null && (other == this || (this.skillInfoList_.Equals(other.skillInfoList_) && this.gaPassiveSkills_.Equals(other.gaPassiveSkills_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601938C RID: 103308 RVA: 0x003ADAE0 File Offset: 0x003ABCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skillInfoList_.GetHashCode();
			num ^= this.gaPassiveSkills_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601938D RID: 103309 RVA: 0x003ADB22 File Offset: 0x003ABD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601938E RID: 103310 RVA: 0x003ADB2F File Offset: 0x003ABD2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601938F RID: 103311 RVA: 0x003ADB38 File Offset: 0x003ABD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillInfoList_.WriteTo(ref output, SkillComponentPb._repeated_skillInfoList_codec);
			this.gaPassiveSkills_.WriteTo(ref output, SkillComponentPb._repeated_gaPassiveSkills_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019390 RID: 103312 RVA: 0x003ADB70 File Offset: 0x003ABD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skillInfoList_.CalculateSize(SkillComponentPb._repeated_skillInfoList_codec);
			num += this.gaPassiveSkills_.CalculateSize(SkillComponentPb._repeated_gaPassiveSkills_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019391 RID: 103313 RVA: 0x003ADBBC File Offset: 0x003ABDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.skillInfoList_.Add(other.skillInfoList_);
			this.gaPassiveSkills_.Add(other.gaPassiveSkills_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019392 RID: 103314 RVA: 0x003ADBFB File Offset: 0x003ABDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019393 RID: 103315 RVA: 0x003ADC04 File Offset: 0x003ABE04
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
						this.gaPassiveSkills_.AddEntriesFrom(ref input, SkillComponentPb._repeated_gaPassiveSkills_codec);
					}
				}
				else
				{
					this.skillInfoList_.AddEntriesFrom(ref input, SkillComponentPb._repeated_skillInfoList_codec);
				}
			}
		}

		// Token: 0x04009545 RID: 38213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009546 RID: 38214
		public const int SkillInfoListFieldNumber = 1;

		// Token: 0x04009547 RID: 38215
		private static readonly FieldCodec<SkillExecuteInfoPb> _repeated_skillInfoList_codec = FieldCodec.ForMessage<SkillExecuteInfoPb>(10U, SkillExecuteInfoPb.Parser);

		// Token: 0x04009548 RID: 38216
		private readonly RepeatedField<SkillExecuteInfoPb> skillInfoList_ = new RepeatedField<SkillExecuteInfoPb>();

		// Token: 0x04009549 RID: 38217
		public const int GaPassiveSkillsFieldNumber = 2;

		// Token: 0x0400954A RID: 38218
		private static readonly FieldCodec<GaPassiveSkill> _repeated_gaPassiveSkills_codec = FieldCodec.ForMessage<GaPassiveSkill>(18U, GaPassiveSkill.Parser);

		// Token: 0x0400954B RID: 38219
		private readonly RepeatedField<GaPassiveSkill> gaPassiveSkills_ = new RepeatedField<GaPassiveSkill>();
	}
}
