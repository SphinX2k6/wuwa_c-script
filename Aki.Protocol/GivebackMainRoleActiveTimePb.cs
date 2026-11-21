using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DD RID: 1757
	public sealed class GivebackMainRoleActiveTimePb : IMessage<GivebackMainRoleActiveTimePb>, IMessage, IEquatable<GivebackMainRoleActiveTimePb>, IDeepCloneable<GivebackMainRoleActiveTimePb>, IBufferMessage
	{
		// Token: 0x0600A09B RID: 41115 RVA: 0x001850DC File Offset: 0x001832DC
		[NullableContext(1)]
		public static GivebackMainRoleActiveTimePb Create()
		{
			return new GivebackMainRoleActiveTimePb();
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600A09C RID: 41116 RVA: 0x001850E3 File Offset: 0x001832E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GivebackMainRoleActiveTimePb> Parser
		{
			get
			{
				return GivebackMainRoleActiveTimePb._parser;
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x001850EA File Offset: 0x001832EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600A09E RID: 41118 RVA: 0x001850ED File Offset: 0x001832ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackMainRoleActiveTimePb.Descriptor;
			}
		}

		// Token: 0x0600A09F RID: 41119 RVA: 0x001850F4 File Offset: 0x001832F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackMainRoleActiveTimePb()
		{
		}

		// Token: 0x0600A0A0 RID: 41120 RVA: 0x001850FC File Offset: 0x001832FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackMainRoleActiveTimePb(GivebackMainRoleActiveTimePb other) : this()
		{
			this.roleId_ = other.roleId_;
			this.activeTime_ = other.activeTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x0018512D File Offset: 0x0018332D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackMainRoleActiveTimePb Clone()
		{
			return new GivebackMainRoleActiveTimePb(this);
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x00185135 File Offset: 0x00183335
		// (set) Token: 0x0600A0A3 RID: 41123 RVA: 0x0018513D File Offset: 0x0018333D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x00185146 File Offset: 0x00183346
		// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x0018514E File Offset: 0x0018334E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ActiveTime
		{
			get
			{
				return this.activeTime_;
			}
			set
			{
				this.activeTime_ = value;
			}
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x00185157 File Offset: 0x00183357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackMainRoleActiveTimePb);
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x00185165 File Offset: 0x00183365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackMainRoleActiveTimePb other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.ActiveTime == other.ActiveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x001851A4 File Offset: 0x001833A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.ActiveTime != 0L)
			{
				num ^= this.ActiveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x001851FC File Offset: 0x001833FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x00185209 File Offset: 0x00183409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x00185214 File Offset: 0x00183414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.ActiveTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ActiveTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x0018526C File Offset: 0x0018346C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.ActiveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ActiveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x001852C4 File Offset: 0x001834C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackMainRoleActiveTimePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.ActiveTime != 0L)
			{
				this.ActiveTime = other.ActiveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x00185314 File Offset: 0x00183514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x00185320 File Offset: 0x00183520
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
						this.ActiveTime = input.ReadInt64();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004B14 RID: 19220
		private static readonly MessageParser<GivebackMainRoleActiveTimePb> _parser = new MessageParser<GivebackMainRoleActiveTimePb>(() => new GivebackMainRoleActiveTimePb());

		// Token: 0x04004B15 RID: 19221
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B16 RID: 19222
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04004B17 RID: 19223
		private int roleId_;

		// Token: 0x04004B18 RID: 19224
		public const int ActiveTimeFieldNumber = 2;

		// Token: 0x04004B19 RID: 19225
		private long activeTime_;
	}
}
