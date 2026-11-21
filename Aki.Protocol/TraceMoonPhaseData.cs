using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001445 RID: 5189
	public sealed class TraceMoonPhaseData : IMessage<TraceMoonPhaseData>, IMessage, IEquatable<TraceMoonPhaseData>, IDeepCloneable<TraceMoonPhaseData>, IBufferMessage
	{
		// Token: 0x0601B918 RID: 112920 RVA: 0x00401B6F File Offset: 0x003FFD6F
		[NullableContext(1)]
		public static TraceMoonPhaseData Create()
		{
			return new TraceMoonPhaseData();
		}

		// Token: 0x17005D54 RID: 23892
		// (get) Token: 0x0601B919 RID: 112921 RVA: 0x00401B76 File Offset: 0x003FFD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D55 RID: 23893
		// (get) Token: 0x0601B91A RID: 112922 RVA: 0x00401B79 File Offset: 0x003FFD79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceMoonPhaseData.Descriptor;
			}
		}

		// Token: 0x0601B91B RID: 112923 RVA: 0x00401B80 File Offset: 0x003FFD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseData()
		{
		}

		// Token: 0x0601B91C RID: 112924 RVA: 0x00401B88 File Offset: 0x003FFD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseData(TraceMoonPhaseData other) : this()
		{
			this.reward_ = other.reward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B91D RID: 112925 RVA: 0x00401BAD File Offset: 0x003FFDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseData Clone()
		{
			return new TraceMoonPhaseData(this);
		}

		// Token: 0x17005D56 RID: 23894
		// (get) Token: 0x0601B91E RID: 112926 RVA: 0x00401BB5 File Offset: 0x003FFDB5
		// (set) Token: 0x0601B91F RID: 112927 RVA: 0x00401BBD File Offset: 0x003FFDBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x0601B920 RID: 112928 RVA: 0x00401BC6 File Offset: 0x003FFDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceMoonPhaseData);
		}

		// Token: 0x0601B921 RID: 112929 RVA: 0x00401BD4 File Offset: 0x003FFDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceMoonPhaseData other)
		{
			return other != null && (other == this || (this.Reward == other.Reward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B922 RID: 112930 RVA: 0x00401C04 File Offset: 0x003FFE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reward)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B923 RID: 112931 RVA: 0x00401C43 File Offset: 0x003FFE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B924 RID: 112932 RVA: 0x00401C50 File Offset: 0x003FFE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B925 RID: 112933 RVA: 0x00401C59 File Offset: 0x003FFE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reward)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B926 RID: 112934 RVA: 0x00401C8C File Offset: 0x003FFE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B927 RID: 112935 RVA: 0x00401CBE File Offset: 0x003FFEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceMoonPhaseData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reward)
			{
				this.Reward = other.Reward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B928 RID: 112936 RVA: 0x00401CEF File Offset: 0x003FFEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B929 RID: 112937 RVA: 0x00401CF8 File Offset: 0x003FFEF8
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
					this.Reward = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A054 RID: 41044
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A055 RID: 41045
		public const int RewardFieldNumber = 1;

		// Token: 0x0400A056 RID: 41046
		private bool reward_;
	}
}
