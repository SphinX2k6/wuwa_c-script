using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C1 RID: 2497
	[NetMessage(EMessageId.MatchTeamNotify)]
	public sealed class MatchTeamNotify : IMessage<MatchTeamNotify>, IMessage, IEquatable<MatchTeamNotify>, IDeepCloneable<MatchTeamNotify>, IBufferMessage
	{
		// Token: 0x0600DB21 RID: 56097 RVA: 0x0020302B File Offset: 0x0020122B
		[NullableContext(1)]
		public static MatchTeamNotify Create()
		{
			return new MatchTeamNotify();
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x0600DB22 RID: 56098 RVA: 0x00203032 File Offset: 0x00201232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x0600DB23 RID: 56099 RVA: 0x00203035 File Offset: 0x00201235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchTeamNotify.Descriptor;
			}
		}

		// Token: 0x0600DB24 RID: 56100 RVA: 0x0020303C File Offset: 0x0020123C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamNotify()
		{
		}

		// Token: 0x0600DB25 RID: 56101 RVA: 0x00203044 File Offset: 0x00201244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamNotify(MatchTeamNotify other) : this()
		{
			this.teamInfo_ = ((other.teamInfo_ != null) ? other.teamInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB26 RID: 56102 RVA: 0x00203079 File Offset: 0x00201279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamNotify Clone()
		{
			return new MatchTeamNotify(this);
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x0600DB27 RID: 56103 RVA: 0x00203081 File Offset: 0x00201281
		// (set) Token: 0x0600DB28 RID: 56104 RVA: 0x00203089 File Offset: 0x00201289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamInfo TeamInfo
		{
			get
			{
				return this.teamInfo_;
			}
			set
			{
				this.teamInfo_ = value;
			}
		}

		// Token: 0x0600DB29 RID: 56105 RVA: 0x00203092 File Offset: 0x00201292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchTeamNotify);
		}

		// Token: 0x0600DB2A RID: 56106 RVA: 0x002030A0 File Offset: 0x002012A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchTeamNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TeamInfo, other.TeamInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB2B RID: 56107 RVA: 0x002030D4 File Offset: 0x002012D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.teamInfo_ != null)
			{
				num ^= this.TeamInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB2C RID: 56108 RVA: 0x00203110 File Offset: 0x00201310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB2D RID: 56109 RVA: 0x0020311D File Offset: 0x0020131D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB2E RID: 56110 RVA: 0x00203126 File Offset: 0x00201326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.teamInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TeamInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB2F RID: 56111 RVA: 0x00203158 File Offset: 0x00201358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.teamInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TeamInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00203198 File Offset: 0x00201398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchTeamNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.teamInfo_ != null)
			{
				if (this.teamInfo_ == null)
				{
					this.TeamInfo = new MatchTeamInfo();
				}
				this.TeamInfo.MergeFrom(other.TeamInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB31 RID: 56113 RVA: 0x002031EC File Offset: 0x002013EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x002031F8 File Offset: 0x002013F8
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.teamInfo_ == null)
					{
						this.TeamInfo = new MatchTeamInfo();
					}
					input.ReadMessage(this.TeamInfo);
				}
			}
		}

		// Token: 0x04005AFE RID: 23294
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AFF RID: 23295
		public const int TeamInfoFieldNumber = 4;

		// Token: 0x04005B00 RID: 23296
		private MatchTeamInfo teamInfo_;
	}
}
