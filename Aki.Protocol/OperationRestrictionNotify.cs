using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA4 RID: 2980
	[NetMessage(EMessageId.OperationRestrictionNotify)]
	public sealed class OperationRestrictionNotify : IMessage<OperationRestrictionNotify>, IMessage, IEquatable<OperationRestrictionNotify>, IDeepCloneable<OperationRestrictionNotify>, IBufferMessage
	{
		// Token: 0x06010288 RID: 66184 RVA: 0x0025BD7D File Offset: 0x00259F7D
		[NullableContext(1)]
		public static OperationRestrictionNotify Create()
		{
			return new OperationRestrictionNotify();
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x06010289 RID: 66185 RVA: 0x0025BD84 File Offset: 0x00259F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0601028A RID: 66186 RVA: 0x0025BD87 File Offset: 0x00259F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OperationRestrictionNotify.Descriptor;
			}
		}

		// Token: 0x0601028B RID: 66187 RVA: 0x0025BD8E File Offset: 0x00259F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OperationRestrictionNotify()
		{
		}

		// Token: 0x0601028C RID: 66188 RVA: 0x0025BDA1 File Offset: 0x00259FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OperationRestrictionNotify(OperationRestrictionNotify other) : this()
		{
			this.params_ = other.params_;
			this.isNull_ = other.isNull_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601028D RID: 66189 RVA: 0x0025BDD2 File Offset: 0x00259FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OperationRestrictionNotify Clone()
		{
			return new OperationRestrictionNotify(this);
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0601028E RID: 66190 RVA: 0x0025BDDA File Offset: 0x00259FDA
		// (set) Token: 0x0601028F RID: 66191 RVA: 0x0025BDE2 File Offset: 0x00259FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Params
		{
			get
			{
				return this.params_;
			}
			set
			{
				this.params_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x06010290 RID: 66192 RVA: 0x0025BDF5 File Offset: 0x00259FF5
		// (set) Token: 0x06010291 RID: 66193 RVA: 0x0025BDFD File Offset: 0x00259FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNull
		{
			get
			{
				return this.isNull_;
			}
			set
			{
				this.isNull_ = value;
			}
		}

		// Token: 0x06010292 RID: 66194 RVA: 0x0025BE06 File Offset: 0x0025A006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OperationRestrictionNotify);
		}

		// Token: 0x06010293 RID: 66195 RVA: 0x0025BE14 File Offset: 0x0025A014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OperationRestrictionNotify other)
		{
			return other != null && (other == this || (!(this.Params != other.Params) && this.IsNull == other.IsNull && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010294 RID: 66196 RVA: 0x0025BE64 File Offset: 0x0025A064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Params.Length != 0)
			{
				num ^= this.Params.GetHashCode();
			}
			if (this.IsNull)
			{
				num ^= this.IsNull.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010295 RID: 66197 RVA: 0x0025BEBE File Offset: 0x0025A0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010296 RID: 66198 RVA: 0x0025BECB File Offset: 0x0025A0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010297 RID: 66199 RVA: 0x0025BED4 File Offset: 0x0025A0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Params.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Params);
			}
			if (this.IsNull)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsNull);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010298 RID: 66200 RVA: 0x0025BF34 File Offset: 0x0025A134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Params.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Params);
			}
			if (this.IsNull)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010299 RID: 66201 RVA: 0x0025BF84 File Offset: 0x0025A184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OperationRestrictionNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Params.Length != 0)
			{
				this.Params = other.Params;
			}
			if (other.IsNull)
			{
				this.IsNull = other.IsNull;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601029A RID: 66202 RVA: 0x0025BFD9 File Offset: 0x0025A1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601029B RID: 66203 RVA: 0x0025BFE4 File Offset: 0x0025A1E4
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsNull = input.ReadBool();
					}
				}
				else
				{
					this.Params = input.ReadString();
				}
			}
		}

		// Token: 0x040066EF RID: 26351
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066F0 RID: 26352
		public const int ParamsFieldNumber = 1;

		// Token: 0x040066F1 RID: 26353
		private string params_ = "";

		// Token: 0x040066F2 RID: 26354
		public const int IsNullFieldNumber = 7;

		// Token: 0x040066F3 RID: 26355
		private bool isNull_;
	}
}
