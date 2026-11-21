using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AE RID: 4782
	public sealed class SolarSchoolInfluenceLevelPb : IMessage<SolarSchoolInfluenceLevelPb>, IMessage, IEquatable<SolarSchoolInfluenceLevelPb>, IDeepCloneable<SolarSchoolInfluenceLevelPb>, IBufferMessage
	{
		// Token: 0x0601986B RID: 104555 RVA: 0x003B93B7 File Offset: 0x003B75B7
		[NullableContext(1)]
		public static SolarSchoolInfluenceLevelPb Create()
		{
			return new SolarSchoolInfluenceLevelPb();
		}

		// Token: 0x17005664 RID: 22116
		// (get) Token: 0x0601986C RID: 104556 RVA: 0x003B93BE File Offset: 0x003B75BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SolarSchoolInfluenceLevelPb> Parser
		{
			get
			{
				return SolarSchoolInfluenceLevelPb._parser;
			}
		}

		// Token: 0x17005665 RID: 22117
		// (get) Token: 0x0601986D RID: 104557 RVA: 0x003B93C5 File Offset: 0x003B75C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005666 RID: 22118
		// (get) Token: 0x0601986E RID: 104558 RVA: 0x003B93C8 File Offset: 0x003B75C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolInfluenceLevelPb.Descriptor;
			}
		}

		// Token: 0x0601986F RID: 104559 RVA: 0x003B93CF File Offset: 0x003B75CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolInfluenceLevelPb()
		{
		}

		// Token: 0x06019870 RID: 104560 RVA: 0x003B93D7 File Offset: 0x003B75D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolInfluenceLevelPb(SolarSchoolInfluenceLevelPb other) : this()
		{
			this.influenceId_ = other.influenceId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019871 RID: 104561 RVA: 0x003B9408 File Offset: 0x003B7608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolInfluenceLevelPb Clone()
		{
			return new SolarSchoolInfluenceLevelPb(this);
		}

		// Token: 0x17005667 RID: 22119
		// (get) Token: 0x06019872 RID: 104562 RVA: 0x003B9410 File Offset: 0x003B7610
		// (set) Token: 0x06019873 RID: 104563 RVA: 0x003B9418 File Offset: 0x003B7618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InfluenceId
		{
			get
			{
				return this.influenceId_;
			}
			set
			{
				this.influenceId_ = value;
			}
		}

		// Token: 0x17005668 RID: 22120
		// (get) Token: 0x06019874 RID: 104564 RVA: 0x003B9421 File Offset: 0x003B7621
		// (set) Token: 0x06019875 RID: 104565 RVA: 0x003B9429 File Offset: 0x003B7629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06019876 RID: 104566 RVA: 0x003B9432 File Offset: 0x003B7632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolInfluenceLevelPb);
		}

		// Token: 0x06019877 RID: 104567 RVA: 0x003B9440 File Offset: 0x003B7640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolInfluenceLevelPb other)
		{
			return other != null && (other == this || (this.InfluenceId == other.InfluenceId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019878 RID: 104568 RVA: 0x003B9480 File Offset: 0x003B7680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InfluenceId != 0)
			{
				num ^= this.InfluenceId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019879 RID: 104569 RVA: 0x003B94D8 File Offset: 0x003B76D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601987A RID: 104570 RVA: 0x003B94E5 File Offset: 0x003B76E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601987B RID: 104571 RVA: 0x003B94F0 File Offset: 0x003B76F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InfluenceId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InfluenceId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601987C RID: 104572 RVA: 0x003B9548 File Offset: 0x003B7748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InfluenceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InfluenceId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601987D RID: 104573 RVA: 0x003B95A0 File Offset: 0x003B77A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolInfluenceLevelPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InfluenceId != 0)
			{
				this.InfluenceId = other.InfluenceId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601987E RID: 104574 RVA: 0x003B95F0 File Offset: 0x003B77F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601987F RID: 104575 RVA: 0x003B95FC File Offset: 0x003B77FC
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.InfluenceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096D7 RID: 38615
		private static readonly MessageParser<SolarSchoolInfluenceLevelPb> _parser = new MessageParser<SolarSchoolInfluenceLevelPb>(() => new SolarSchoolInfluenceLevelPb());

		// Token: 0x040096D8 RID: 38616
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096D9 RID: 38617
		public const int InfluenceIdFieldNumber = 1;

		// Token: 0x040096DA RID: 38618
		private int influenceId_;

		// Token: 0x040096DB RID: 38619
		public const int LevelFieldNumber = 2;

		// Token: 0x040096DC RID: 38620
		private int level_;
	}
}
