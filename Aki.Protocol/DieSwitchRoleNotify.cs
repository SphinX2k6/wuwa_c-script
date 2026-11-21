using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C1 RID: 961
	[NetMessage(EMessageId.DieSwitchRoleNotify)]
	public sealed class DieSwitchRoleNotify : IMessage<DieSwitchRoleNotify>, IMessage, IEquatable<DieSwitchRoleNotify>, IDeepCloneable<DieSwitchRoleNotify>, IBufferMessage
	{
		// Token: 0x06005E57 RID: 24151 RVA: 0x000E5174 File Offset: 0x000E3374
		[NullableContext(1)]
		public static DieSwitchRoleNotify Create()
		{
			return new DieSwitchRoleNotify();
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06005E58 RID: 24152 RVA: 0x000E517B File Offset: 0x000E337B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06005E59 RID: 24153 RVA: 0x000E517E File Offset: 0x000E337E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DieSwitchRoleNotify.Descriptor;
			}
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x000E5185 File Offset: 0x000E3385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DieSwitchRoleNotify()
		{
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x000E518D File Offset: 0x000E338D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DieSwitchRoleNotify(DieSwitchRoleNotify other) : this()
		{
			this.curRoleId_ = other.curRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x000E51B2 File Offset: 0x000E33B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DieSwitchRoleNotify Clone()
		{
			return new DieSwitchRoleNotify(this);
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06005E5D RID: 24157 RVA: 0x000E51BA File Offset: 0x000E33BA
		// (set) Token: 0x06005E5E RID: 24158 RVA: 0x000E51C2 File Offset: 0x000E33C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRoleId
		{
			get
			{
				return this.curRoleId_;
			}
			set
			{
				this.curRoleId_ = value;
			}
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x000E51CB File Offset: 0x000E33CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DieSwitchRoleNotify);
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x000E51D9 File Offset: 0x000E33D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DieSwitchRoleNotify other)
		{
			return other != null && (other == this || (this.CurRoleId == other.CurRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x000E5208 File Offset: 0x000E3408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRoleId != 0)
			{
				num ^= this.CurRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x000E5247 File Offset: 0x000E3447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x000E5254 File Offset: 0x000E3454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x000E525D File Offset: 0x000E345D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x000E5290 File Offset: 0x000E3490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x000E52CE File Offset: 0x000E34CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DieSwitchRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRoleId != 0)
			{
				this.CurRoleId = other.CurRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x000E52FF File Offset: 0x000E34FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x000E5308 File Offset: 0x000E3508
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003733 RID: 14131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003734 RID: 14132
		public const int CurRoleIdFieldNumber = 11;

		// Token: 0x04003735 RID: 14133
		private int curRoleId_;
	}
}
