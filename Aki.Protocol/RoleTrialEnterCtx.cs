using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C9 RID: 4297
	public sealed class RoleTrialEnterCtx : IMessage<RoleTrialEnterCtx>, IMessage, IEquatable<RoleTrialEnterCtx>, IDeepCloneable<RoleTrialEnterCtx>, IBufferMessage
	{
		// Token: 0x06016EDE RID: 93918 RVA: 0x00354329 File Offset: 0x00352529
		[NullableContext(1)]
		public static RoleTrialEnterCtx Create()
		{
			return new RoleTrialEnterCtx();
		}

		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x06016EDF RID: 93919 RVA: 0x00354330 File Offset: 0x00352530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x06016EE0 RID: 93920 RVA: 0x00354333 File Offset: 0x00352533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialEnterCtx.Descriptor;
			}
		}

		// Token: 0x06016EE1 RID: 93921 RVA: 0x0035433A File Offset: 0x0035253A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialEnterCtx()
		{
		}

		// Token: 0x06016EE2 RID: 93922 RVA: 0x00354342 File Offset: 0x00352542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialEnterCtx(RoleTrialEnterCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EE3 RID: 93923 RVA: 0x00354373 File Offset: 0x00352573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialEnterCtx Clone()
		{
			return new RoleTrialEnterCtx(this);
		}

		// Token: 0x17004CCF RID: 19663
		// (get) Token: 0x06016EE4 RID: 93924 RVA: 0x0035437B File Offset: 0x0035257B
		// (set) Token: 0x06016EE5 RID: 93925 RVA: 0x00354383 File Offset: 0x00352583
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

		// Token: 0x17004CD0 RID: 19664
		// (get) Token: 0x06016EE6 RID: 93926 RVA: 0x0035438C File Offset: 0x0035258C
		// (set) Token: 0x06016EE7 RID: 93927 RVA: 0x00354394 File Offset: 0x00352594
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

		// Token: 0x06016EE8 RID: 93928 RVA: 0x0035439D File Offset: 0x0035259D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialEnterCtx);
		}

		// Token: 0x06016EE9 RID: 93929 RVA: 0x003543AB File Offset: 0x003525AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialEnterCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EEA RID: 93930 RVA: 0x003543EC File Offset: 0x003525EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016EEB RID: 93931 RVA: 0x00354444 File Offset: 0x00352644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EEC RID: 93932 RVA: 0x00354451 File Offset: 0x00352651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EED RID: 93933 RVA: 0x0035445C File Offset: 0x0035265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016EEE RID: 93934 RVA: 0x003544B4 File Offset: 0x003526B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EEF RID: 93935 RVA: 0x0035450C File Offset: 0x0035270C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EF0 RID: 93936 RVA: 0x0035455C File Offset: 0x0035275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EF1 RID: 93937 RVA: 0x00354568 File Offset: 0x00352768
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
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040088A0 RID: 34976
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088A1 RID: 34977
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040088A2 RID: 34978
		private int activityId_;

		// Token: 0x040088A3 RID: 34979
		public const int RoleIdFieldNumber = 2;

		// Token: 0x040088A4 RID: 34980
		private int roleId_;
	}
}
