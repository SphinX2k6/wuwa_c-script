using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E1 RID: 4833
	public sealed class SurvivorsRoleEvolve : IMessage<SurvivorsRoleEvolve>, IMessage, IEquatable<SurvivorsRoleEvolve>, IDeepCloneable<SurvivorsRoleEvolve>, IBufferMessage
	{
		// Token: 0x06019B52 RID: 105298 RVA: 0x003BCB1D File Offset: 0x003BAD1D
		[NullableContext(1)]
		public static SurvivorsRoleEvolve Create()
		{
			return new SurvivorsRoleEvolve();
		}

		// Token: 0x170056BA RID: 22202
		// (get) Token: 0x06019B53 RID: 105299 RVA: 0x003BCB24 File Offset: 0x003BAD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056BB RID: 22203
		// (get) Token: 0x06019B54 RID: 105300 RVA: 0x003BCB27 File Offset: 0x003BAD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRoleEvolve.Descriptor;
			}
		}

		// Token: 0x06019B55 RID: 105301 RVA: 0x003BCB2E File Offset: 0x003BAD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleEvolve()
		{
		}

		// Token: 0x06019B56 RID: 105302 RVA: 0x003BCB36 File Offset: 0x003BAD36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleEvolve(SurvivorsRoleEvolve other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B57 RID: 105303 RVA: 0x003BCB5B File Offset: 0x003BAD5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRoleEvolve Clone()
		{
			return new SurvivorsRoleEvolve(this);
		}

		// Token: 0x170056BC RID: 22204
		// (get) Token: 0x06019B58 RID: 105304 RVA: 0x003BCB63 File Offset: 0x003BAD63
		// (set) Token: 0x06019B59 RID: 105305 RVA: 0x003BCB6B File Offset: 0x003BAD6B
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

		// Token: 0x06019B5A RID: 105306 RVA: 0x003BCB74 File Offset: 0x003BAD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRoleEvolve);
		}

		// Token: 0x06019B5B RID: 105307 RVA: 0x003BCB82 File Offset: 0x003BAD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRoleEvolve other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019B5C RID: 105308 RVA: 0x003BCBB0 File Offset: 0x003BADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06019B5D RID: 105309 RVA: 0x003BCBEF File Offset: 0x003BADEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B5E RID: 105310 RVA: 0x003BCBFC File Offset: 0x003BADFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B5F RID: 105311 RVA: 0x003BCC05 File Offset: 0x003BAE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B60 RID: 105312 RVA: 0x003BCC38 File Offset: 0x003BAE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06019B61 RID: 105313 RVA: 0x003BCC76 File Offset: 0x003BAE76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRoleEvolve other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B62 RID: 105314 RVA: 0x003BCCA7 File Offset: 0x003BAEA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B63 RID: 105315 RVA: 0x003BCCB0 File Offset: 0x003BAEB0
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
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096A5 RID: 38565
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096A6 RID: 38566
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040096A7 RID: 38567
		private int roleId_;
	}
}
