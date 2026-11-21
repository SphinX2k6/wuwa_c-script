using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4B RID: 3403
	public sealed class PinballRoles : IMessage<PinballRoles>, IMessage, IEquatable<PinballRoles>, IDeepCloneable<PinballRoles>, IBufferMessage
	{
		// Token: 0x0601261E RID: 75294 RVA: 0x002AF55D File Offset: 0x002AD75D
		[NullableContext(1)]
		public static PinballRoles Create()
		{
			return new PinballRoles();
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0601261F RID: 75295 RVA: 0x002AF564 File Offset: 0x002AD764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x06012620 RID: 75296 RVA: 0x002AF567 File Offset: 0x002AD767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoles.Descriptor;
			}
		}

		// Token: 0x06012621 RID: 75297 RVA: 0x002AF56E File Offset: 0x002AD76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles()
		{
		}

		// Token: 0x06012622 RID: 75298 RVA: 0x002AF581 File Offset: 0x002AD781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles(PinballRoles other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012623 RID: 75299 RVA: 0x002AF5AB File Offset: 0x002AD7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles Clone()
		{
			return new PinballRoles(this);
		}

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x06012624 RID: 75300 RVA: 0x002AF5B3 File Offset: 0x002AD7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballRoleData> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x06012625 RID: 75301 RVA: 0x002AF5BB File Offset: 0x002AD7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoles);
		}

		// Token: 0x06012626 RID: 75302 RVA: 0x002AF5C9 File Offset: 0x002AD7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoles other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012627 RID: 75303 RVA: 0x002AF5FC File Offset: 0x002AD7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012628 RID: 75304 RVA: 0x002AF630 File Offset: 0x002AD830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012629 RID: 75305 RVA: 0x002AF63D File Offset: 0x002AD83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601262A RID: 75306 RVA: 0x002AF646 File Offset: 0x002AD846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roles_.WriteTo(ref output, PinballRoles._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601262B RID: 75307 RVA: 0x002AF670 File Offset: 0x002AD870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roles_.CalculateSize(PinballRoles._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601262C RID: 75308 RVA: 0x002AF6A9 File Offset: 0x002AD8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballRoles other)
		{
			if (other == null)
			{
				return;
			}
			this.roles_.Add(other.roles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601262D RID: 75309 RVA: 0x002AF6D7 File Offset: 0x002AD8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601262E RID: 75310 RVA: 0x002AF6E0 File Offset: 0x002AD8E0
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roles_.AddEntriesFrom(ref input, PinballRoles._repeated_roles_codec);
				}
			}
		}

		// Token: 0x040072E5 RID: 29413
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072E6 RID: 29414
		public const int RolesFieldNumber = 1;

		// Token: 0x040072E7 RID: 29415
		private static readonly FieldCodec<PinballRoleData> _repeated_roles_codec = FieldCodec.ForMessage<PinballRoleData>(10U, PinballRoleData.Parser);

		// Token: 0x040072E8 RID: 29416
		private readonly RepeatedField<PinballRoleData> roles_ = new RepeatedField<PinballRoleData>();
	}
}
