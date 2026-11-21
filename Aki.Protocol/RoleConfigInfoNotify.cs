using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001050 RID: 4176
	[NetMessage(EMessageId.RoleConfigInfoNotify)]
	public sealed class RoleConfigInfoNotify : IMessage<RoleConfigInfoNotify>, IMessage, IEquatable<RoleConfigInfoNotify>, IDeepCloneable<RoleConfigInfoNotify>, IBufferMessage
	{
		// Token: 0x06016579 RID: 91513 RVA: 0x0033FC3F File Offset: 0x0033DE3F
		[NullableContext(1)]
		public static RoleConfigInfoNotify Create()
		{
			return new RoleConfigInfoNotify();
		}

		// Token: 0x17004AC5 RID: 19141
		// (get) Token: 0x0601657A RID: 91514 RVA: 0x0033FC46 File Offset: 0x0033DE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x0601657B RID: 91515 RVA: 0x0033FC49 File Offset: 0x0033DE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleConfigInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601657C RID: 91516 RVA: 0x0033FC50 File Offset: 0x0033DE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoNotify()
		{
		}

		// Token: 0x0601657D RID: 91517 RVA: 0x0033FC63 File Offset: 0x0033DE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoNotify(RoleConfigInfoNotify other) : this()
		{
			this.roleConfigs_ = other.roleConfigs_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601657E RID: 91518 RVA: 0x0033FC8D File Offset: 0x0033DE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleConfigInfoNotify Clone()
		{
			return new RoleConfigInfoNotify(this);
		}

		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x0601657F RID: 91519 RVA: 0x0033FC95 File Offset: 0x0033DE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleConfigInfo> RoleConfigs
		{
			get
			{
				return this.roleConfigs_;
			}
		}

		// Token: 0x06016580 RID: 91520 RVA: 0x0033FC9D File Offset: 0x0033DE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleConfigInfoNotify);
		}

		// Token: 0x06016581 RID: 91521 RVA: 0x0033FCAB File Offset: 0x0033DEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleConfigInfoNotify other)
		{
			return other != null && (other == this || (this.roleConfigs_.Equals(other.roleConfigs_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016582 RID: 91522 RVA: 0x0033FCE0 File Offset: 0x0033DEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleConfigs_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016583 RID: 91523 RVA: 0x0033FD14 File Offset: 0x0033DF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016584 RID: 91524 RVA: 0x0033FD21 File Offset: 0x0033DF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016585 RID: 91525 RVA: 0x0033FD2A File Offset: 0x0033DF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleConfigs_.WriteTo(ref output, RoleConfigInfoNotify._repeated_roleConfigs_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016586 RID: 91526 RVA: 0x0033FD54 File Offset: 0x0033DF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleConfigs_.CalculateSize(RoleConfigInfoNotify._repeated_roleConfigs_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016587 RID: 91527 RVA: 0x0033FD8D File Offset: 0x0033DF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleConfigInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleConfigs_.Add(other.roleConfigs_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016588 RID: 91528 RVA: 0x0033FDBB File Offset: 0x0033DFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016589 RID: 91529 RVA: 0x0033FDC4 File Offset: 0x0033DFC4
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleConfigs_.AddEntriesFrom(ref input, RoleConfigInfoNotify._repeated_roleConfigs_codec);
				}
			}
		}

		// Token: 0x04008617 RID: 34327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008618 RID: 34328
		public const int RoleConfigsFieldNumber = 14;

		// Token: 0x04008619 RID: 34329
		private static readonly FieldCodec<RoleConfigInfo> _repeated_roleConfigs_codec = FieldCodec.ForMessage<RoleConfigInfo>(114U, RoleConfigInfo.Parser);

		// Token: 0x0400861A RID: 34330
		private readonly RepeatedField<RoleConfigInfo> roleConfigs_ = new RepeatedField<RoleConfigInfo>();
	}
}
