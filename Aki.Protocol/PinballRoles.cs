using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5B RID: 3419
	public sealed class PinballRoles : IMessage<PinballRoles>, IMessage, IEquatable<PinballRoles>, IDeepCloneable<PinballRoles>, IBufferMessage
	{
		// Token: 0x0601271A RID: 75546 RVA: 0x002B1181 File Offset: 0x002AF381
		[NullableContext(1)]
		public static PinballRoles Create()
		{
			return new PinballRoles();
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0601271B RID: 75547 RVA: 0x002B1188 File Offset: 0x002AF388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0601271C RID: 75548 RVA: 0x002B118B File Offset: 0x002AF38B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballRoles.Descriptor;
			}
		}

		// Token: 0x0601271D RID: 75549 RVA: 0x002B1192 File Offset: 0x002AF392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles()
		{
		}

		// Token: 0x0601271E RID: 75550 RVA: 0x002B11A5 File Offset: 0x002AF3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles(PinballRoles other) : this()
		{
			this.roles_ = other.roles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601271F RID: 75551 RVA: 0x002B11CF File Offset: 0x002AF3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballRoles Clone()
		{
			return new PinballRoles(this);
		}

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x06012720 RID: 75552 RVA: 0x002B11D7 File Offset: 0x002AF3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballRoleData> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x06012721 RID: 75553 RVA: 0x002B11DF File Offset: 0x002AF3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballRoles);
		}

		// Token: 0x06012722 RID: 75554 RVA: 0x002B11ED File Offset: 0x002AF3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballRoles other)
		{
			return other != null && (other == this || (this.roles_.Equals(other.roles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012723 RID: 75555 RVA: 0x002B1220 File Offset: 0x002AF420
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

		// Token: 0x06012724 RID: 75556 RVA: 0x002B1254 File Offset: 0x002AF454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012725 RID: 75557 RVA: 0x002B1261 File Offset: 0x002AF461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012726 RID: 75558 RVA: 0x002B126A File Offset: 0x002AF46A
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

		// Token: 0x06012727 RID: 75559 RVA: 0x002B1294 File Offset: 0x002AF494
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

		// Token: 0x06012728 RID: 75560 RVA: 0x002B12CD File Offset: 0x002AF4CD
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

		// Token: 0x06012729 RID: 75561 RVA: 0x002B12FB File Offset: 0x002AF4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601272A RID: 75562 RVA: 0x002B1304 File Offset: 0x002AF504
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

		// Token: 0x040072CD RID: 29389
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072CE RID: 29390
		public const int RolesFieldNumber = 1;

		// Token: 0x040072CF RID: 29391
		private static readonly FieldCodec<PinballRoleData> _repeated_roles_codec = FieldCodec.ForMessage<PinballRoleData>(10U, PinballRoleData.Parser);

		// Token: 0x040072D0 RID: 29392
		private readonly RepeatedField<PinballRoleData> roles_ = new RepeatedField<PinballRoleData>();
	}
}
