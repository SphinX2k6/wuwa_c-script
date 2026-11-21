using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B0 RID: 2480
	[NetMessage(EMessageId.MatchTeamNotify)]
	public sealed class MatchTeamNotify : IMessage<MatchTeamNotify>, IMessage, IEquatable<MatchTeamNotify>, IDeepCloneable<MatchTeamNotify>, IBufferMessage
	{
		// Token: 0x0600DA07 RID: 55815 RVA: 0x00200E37 File Offset: 0x001FF037
		[NullableContext(1)]
		public static MatchTeamNotify Create()
		{
			return new MatchTeamNotify();
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x0600DA08 RID: 55816 RVA: 0x00200E3E File Offset: 0x001FF03E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x0600DA09 RID: 55817 RVA: 0x00200E41 File Offset: 0x001FF041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchTeamNotify.Descriptor;
			}
		}

		// Token: 0x0600DA0A RID: 55818 RVA: 0x00200E48 File Offset: 0x001FF048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamNotify()
		{
		}

		// Token: 0x0600DA0B RID: 55819 RVA: 0x00200E50 File Offset: 0x001FF050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamNotify(MatchTeamNotify other) : this()
		{
			this.teamInfo_ = ((other.teamInfo_ != null) ? other.teamInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA0C RID: 55820 RVA: 0x00200E85 File Offset: 0x001FF085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchTeamNotify Clone()
		{
			return new MatchTeamNotify(this);
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x0600DA0D RID: 55821 RVA: 0x00200E8D File Offset: 0x001FF08D
		// (set) Token: 0x0600DA0E RID: 55822 RVA: 0x00200E95 File Offset: 0x001FF095
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

		// Token: 0x0600DA0F RID: 55823 RVA: 0x00200E9E File Offset: 0x001FF09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchTeamNotify);
		}

		// Token: 0x0600DA10 RID: 55824 RVA: 0x00200EAC File Offset: 0x001FF0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchTeamNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TeamInfo, other.TeamInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA11 RID: 55825 RVA: 0x00200EE0 File Offset: 0x001FF0E0
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

		// Token: 0x0600DA12 RID: 55826 RVA: 0x00200F1C File Offset: 0x001FF11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA13 RID: 55827 RVA: 0x00200F29 File Offset: 0x001FF129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA14 RID: 55828 RVA: 0x00200F32 File Offset: 0x001FF132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.teamInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TeamInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA15 RID: 55829 RVA: 0x00200F64 File Offset: 0x001FF164
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

		// Token: 0x0600DA16 RID: 55830 RVA: 0x00200FA4 File Offset: 0x001FF1A4
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

		// Token: 0x0600DA17 RID: 55831 RVA: 0x00200FF8 File Offset: 0x001FF1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA18 RID: 55832 RVA: 0x00201004 File Offset: 0x001FF204
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
				if (num != 66U)
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

		// Token: 0x04005B07 RID: 23303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B08 RID: 23304
		public const int TeamInfoFieldNumber = 8;

		// Token: 0x04005B09 RID: 23305
		private MatchTeamInfo teamInfo_;
	}
}
