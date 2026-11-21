using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C3 RID: 1475
	[NetMessage(EMessageId.FloroRanchPlayWeeklyEndNotify)]
	public sealed class FloroRanchPlayWeeklyEndNotify : IMessage<FloroRanchPlayWeeklyEndNotify>, IMessage, IEquatable<FloroRanchPlayWeeklyEndNotify>, IDeepCloneable<FloroRanchPlayWeeklyEndNotify>, IBufferMessage
	{
		// Token: 0x0600890B RID: 35083 RVA: 0x0014C0BF File Offset: 0x0014A2BF
		[NullableContext(1)]
		public static FloroRanchPlayWeeklyEndNotify Create()
		{
			return new FloroRanchPlayWeeklyEndNotify();
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600890C RID: 35084 RVA: 0x0014C0C6 File Offset: 0x0014A2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x0600890D RID: 35085 RVA: 0x0014C0C9 File Offset: 0x0014A2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayWeeklyEndNotify.Descriptor;
			}
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x0014C0D0 File Offset: 0x0014A2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyEndNotify()
		{
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x0014C0D8 File Offset: 0x0014A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyEndNotify(FloroRanchPlayWeeklyEndNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x0014C109 File Offset: 0x0014A309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayWeeklyEndNotify Clone()
		{
			return new FloroRanchPlayWeeklyEndNotify(this);
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06008911 RID: 35089 RVA: 0x0014C111 File Offset: 0x0014A311
		// (set) Token: 0x06008912 RID: 35090 RVA: 0x0014C119 File Offset: 0x0014A319
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

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06008913 RID: 35091 RVA: 0x0014C122 File Offset: 0x0014A322
		// (set) Token: 0x06008914 RID: 35092 RVA: 0x0014C12A File Offset: 0x0014A32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x0014C133 File Offset: 0x0014A333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayWeeklyEndNotify);
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x0014C141 File Offset: 0x0014A341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayWeeklyEndNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x0014C180 File Offset: 0x0014A380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x0014C1D8 File Offset: 0x0014A3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x0014C1E5 File Offset: 0x0014A3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x0014C1F0 File Offset: 0x0014A3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x0014C24C File Offset: 0x0014A44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x0014C2A4 File Offset: 0x0014A4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayWeeklyEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x0014C2F4 File Offset: 0x0014A4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600891E RID: 35102 RVA: 0x0014C300 File Offset: 0x0014A500
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040043FB RID: 17403
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043FC RID: 17404
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040043FD RID: 17405
		private int activityId_;

		// Token: 0x040043FE RID: 17406
		public const int SubInsIdFieldNumber = 8;

		// Token: 0x040043FF RID: 17407
		private int subInsId_;
	}
}
