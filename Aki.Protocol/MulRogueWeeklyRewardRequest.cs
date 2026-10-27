using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE8 RID: 2792
	[NetMessage(EMessageId.MulRogueWeeklyRewardRequest)]
	public sealed class MulRogueWeeklyRewardRequest : IMessage<MulRogueWeeklyRewardRequest>, IMessage, IEquatable<MulRogueWeeklyRewardRequest>, IDeepCloneable<MulRogueWeeklyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F2CD RID: 62157 RVA: 0x00237108 File Offset: 0x00235308
		[NullableContext(1)]
		public static MulRogueWeeklyRewardRequest Create()
		{
			return new MulRogueWeeklyRewardRequest();
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600F2CE RID: 62158 RVA: 0x0023710F File Offset: 0x0023530F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600F2CF RID: 62159 RVA: 0x00237112 File Offset: 0x00235312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRogueWeeklyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F2D0 RID: 62160 RVA: 0x00237119 File Offset: 0x00235319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardRequest()
		{
		}

		// Token: 0x0600F2D1 RID: 62161 RVA: 0x0023712C File Offset: 0x0023532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardRequest(MulRogueWeeklyRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.configId_ = other.configId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2D2 RID: 62162 RVA: 0x00237162 File Offset: 0x00235362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardRequest Clone()
		{
			return new MulRogueWeeklyRewardRequest(this);
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600F2D3 RID: 62163 RVA: 0x0023716A File Offset: 0x0023536A
		// (set) Token: 0x0600F2D4 RID: 62164 RVA: 0x00237172 File Offset: 0x00235372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600F2D5 RID: 62165 RVA: 0x0023717B File Offset: 0x0023537B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigId
		{
			get
			{
				return this.configId_;
			}
		}

		// Token: 0x0600F2D6 RID: 62166 RVA: 0x00237183 File Offset: 0x00235383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRogueWeeklyRewardRequest);
		}

		// Token: 0x0600F2D7 RID: 62167 RVA: 0x00237194 File Offset: 0x00235394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRogueWeeklyRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.configId_.Equals(other.configId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2D8 RID: 62168 RVA: 0x002371E4 File Offset: 0x002353E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.configId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F2D9 RID: 62169 RVA: 0x00237231 File Offset: 0x00235431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2DA RID: 62170 RVA: 0x0023723E File Offset: 0x0023543E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2DB RID: 62171 RVA: 0x00237248 File Offset: 0x00235448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.configId_.WriteTo(ref output, MulRogueWeeklyRewardRequest._repeated_configId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2DC RID: 62172 RVA: 0x00237298 File Offset: 0x00235498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.configId_.CalculateSize(MulRogueWeeklyRewardRequest._repeated_configId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F2DD RID: 62173 RVA: 0x002372EC File Offset: 0x002354EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulRogueWeeklyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.configId_.Add(other.configId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F2DE RID: 62174 RVA: 0x00237339 File Offset: 0x00235539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2DF RID: 62175 RVA: 0x00237344 File Offset: 0x00235544
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
				if (num != 24U)
				{
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.configId_.AddEntriesFrom(ref input, MulRogueWeeklyRewardRequest._repeated_configId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040061E8 RID: 25064
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061E9 RID: 25065
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040061EA RID: 25066
		private int activityId_;

		// Token: 0x040061EB RID: 25067
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x040061EC RID: 25068
		private static readonly FieldCodec<int> _repeated_configId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040061ED RID: 25069
		private readonly RepeatedField<int> configId_ = new RepeatedField<int>();
	}
}
