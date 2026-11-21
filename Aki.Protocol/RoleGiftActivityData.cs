using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106F RID: 4207
	public sealed class RoleGiftActivityData : IMessage<RoleGiftActivityData>, IMessage, IEquatable<RoleGiftActivityData>, IDeepCloneable<RoleGiftActivityData>, IBufferMessage
	{
		// Token: 0x06016815 RID: 92181 RVA: 0x003460CF File Offset: 0x003442CF
		[NullableContext(1)]
		public static RoleGiftActivityData Create()
		{
			return new RoleGiftActivityData();
		}

		// Token: 0x17004B5F RID: 19295
		// (get) Token: 0x06016816 RID: 92182 RVA: 0x003460D6 File Offset: 0x003442D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B60 RID: 19296
		// (get) Token: 0x06016817 RID: 92183 RVA: 0x003460D9 File Offset: 0x003442D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGiftActivityData.Descriptor;
			}
		}

		// Token: 0x06016818 RID: 92184 RVA: 0x003460E0 File Offset: 0x003442E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftActivityData()
		{
		}

		// Token: 0x06016819 RID: 92185 RVA: 0x003460E8 File Offset: 0x003442E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftActivityData(RoleGiftActivityData other) : this()
		{
			this.rewardHadGet_ = other.rewardHadGet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601681A RID: 92186 RVA: 0x0034610D File Offset: 0x0034430D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftActivityData Clone()
		{
			return new RoleGiftActivityData(this);
		}

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x0601681B RID: 92187 RVA: 0x00346115 File Offset: 0x00344315
		// (set) Token: 0x0601681C RID: 92188 RVA: 0x0034611D File Offset: 0x0034431D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardHadGet
		{
			get
			{
				return this.rewardHadGet_;
			}
			set
			{
				this.rewardHadGet_ = value;
			}
		}

		// Token: 0x0601681D RID: 92189 RVA: 0x00346126 File Offset: 0x00344326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGiftActivityData);
		}

		// Token: 0x0601681E RID: 92190 RVA: 0x00346134 File Offset: 0x00344334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGiftActivityData other)
		{
			return other != null && (other == this || (this.RewardHadGet == other.RewardHadGet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601681F RID: 92191 RVA: 0x00346164 File Offset: 0x00344364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardHadGet)
			{
				num ^= this.RewardHadGet.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016820 RID: 92192 RVA: 0x003461A3 File Offset: 0x003443A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016821 RID: 92193 RVA: 0x003461B0 File Offset: 0x003443B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016822 RID: 92194 RVA: 0x003461B9 File Offset: 0x003443B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardHadGet)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.RewardHadGet);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016823 RID: 92195 RVA: 0x003461EC File Offset: 0x003443EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardHadGet)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016824 RID: 92196 RVA: 0x0034621E File Offset: 0x0034441E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGiftActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardHadGet)
			{
				this.RewardHadGet = other.RewardHadGet;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016825 RID: 92197 RVA: 0x0034624F File Offset: 0x0034444F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016826 RID: 92198 RVA: 0x00346258 File Offset: 0x00344458
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RewardHadGet = input.ReadBool();
				}
			}
		}

		// Token: 0x04008700 RID: 34560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008701 RID: 34561
		public const int RewardHadGetFieldNumber = 1;

		// Token: 0x04008702 RID: 34562
		private bool rewardHadGet_;
	}
}
