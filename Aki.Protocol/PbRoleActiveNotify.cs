using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFC RID: 3068
	[NetMessage(EMessageId.PbRoleActiveNotify)]
	public sealed class PbRoleActiveNotify : IMessage<PbRoleActiveNotify>, IMessage, IEquatable<PbRoleActiveNotify>, IDeepCloneable<PbRoleActiveNotify>, IBufferMessage
	{
		// Token: 0x06010AE6 RID: 68326 RVA: 0x00271E72 File Offset: 0x00270072
		[NullableContext(1)]
		public static PbRoleActiveNotify Create()
		{
			return new PbRoleActiveNotify();
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x06010AE7 RID: 68327 RVA: 0x00271E79 File Offset: 0x00270079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x06010AE8 RID: 68328 RVA: 0x00271E7C File Offset: 0x0027007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleActiveNotify.Descriptor;
			}
		}

		// Token: 0x06010AE9 RID: 68329 RVA: 0x00271E83 File Offset: 0x00270083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleActiveNotify()
		{
		}

		// Token: 0x06010AEA RID: 68330 RVA: 0x00271E8B File Offset: 0x0027008B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleActiveNotify(PbRoleActiveNotify other) : this()
		{
			this.role_ = ((other.role_ != null) ? other.role_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AEB RID: 68331 RVA: 0x00271EC0 File Offset: 0x002700C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleActiveNotify Clone()
		{
			return new PbRoleActiveNotify(this);
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x06010AEC RID: 68332 RVA: 0x00271EC8 File Offset: 0x002700C8
		// (set) Token: 0x06010AED RID: 68333 RVA: 0x00271ED0 File Offset: 0x002700D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		// Token: 0x06010AEE RID: 68334 RVA: 0x00271ED9 File Offset: 0x002700D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleActiveNotify);
		}

		// Token: 0x06010AEF RID: 68335 RVA: 0x00271EE7 File Offset: 0x002700E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleActiveNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Role, other.Role) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010AF0 RID: 68336 RVA: 0x00271F1C File Offset: 0x0027011C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.role_ != null)
			{
				num ^= this.Role.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010AF1 RID: 68337 RVA: 0x00271F58 File Offset: 0x00270158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010AF2 RID: 68338 RVA: 0x00271F65 File Offset: 0x00270165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AF3 RID: 68339 RVA: 0x00271F6E File Offset: 0x0027016E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.role_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Role);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010AF4 RID: 68340 RVA: 0x00271FA0 File Offset: 0x002701A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.role_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Role);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010AF5 RID: 68341 RVA: 0x00271FE0 File Offset: 0x002701E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbRoleActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.role_ != null)
			{
				if (this.role_ == null)
				{
					this.Role = new roleInfo();
				}
				this.Role.MergeFrom(other.Role);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010AF6 RID: 68342 RVA: 0x00272034 File Offset: 0x00270234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010AF7 RID: 68343 RVA: 0x00272040 File Offset: 0x00270240
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
					if (this.role_ == null)
					{
						this.Role = new roleInfo();
					}
					input.ReadMessage(this.Role);
				}
			}
		}

		// Token: 0x04006A77 RID: 27255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A78 RID: 27256
		public const int RoleFieldNumber = 4;

		// Token: 0x04006A79 RID: 27257
		private roleInfo role_;
	}
}
