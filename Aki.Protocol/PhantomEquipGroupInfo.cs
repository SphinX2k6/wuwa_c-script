using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCB RID: 3275
	public sealed class PhantomEquipGroupInfo : IMessage<PhantomEquipGroupInfo>, IMessage, IEquatable<PhantomEquipGroupInfo>, IDeepCloneable<PhantomEquipGroupInfo>, IBufferMessage
	{
		// Token: 0x06011BB1 RID: 72625 RVA: 0x002985C0 File Offset: 0x002967C0
		[NullableContext(1)]
		public static PhantomEquipGroupInfo Create()
		{
			return new PhantomEquipGroupInfo();
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x06011BB2 RID: 72626 RVA: 0x002985C7 File Offset: 0x002967C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomEquipGroupInfo> Parser
		{
			get
			{
				return PhantomEquipGroupInfo._parser;
			}
		}

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x06011BB3 RID: 72627 RVA: 0x002985CE File Offset: 0x002967CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x06011BB4 RID: 72628 RVA: 0x002985D1 File Offset: 0x002967D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfo.Descriptor;
			}
		}

		// Token: 0x06011BB5 RID: 72629 RVA: 0x002985D8 File Offset: 0x002967D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfo()
		{
		}

		// Token: 0x06011BB6 RID: 72630 RVA: 0x002985F6 File Offset: 0x002967F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfo(PhantomEquipGroupInfo other) : this()
		{
			this.incId_ = other.incId_.Clone();
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011BB7 RID: 72631 RVA: 0x0029862C File Offset: 0x0029682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfo Clone()
		{
			return new PhantomEquipGroupInfo(this);
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x06011BB8 RID: 72632 RVA: 0x00298634 File Offset: 0x00296834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncId
		{
			get
			{
				return this.incId_;
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x06011BB9 RID: 72633 RVA: 0x0029863C File Offset: 0x0029683C
		// (set) Token: 0x06011BBA RID: 72634 RVA: 0x00298644 File Offset: 0x00296844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06011BBB RID: 72635 RVA: 0x00298657 File Offset: 0x00296857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfo);
		}

		// Token: 0x06011BBC RID: 72636 RVA: 0x00298668 File Offset: 0x00296868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfo other)
		{
			return other != null && (other == this || (this.incId_.Equals(other.incId_) && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011BBD RID: 72637 RVA: 0x002986BC File Offset: 0x002968BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.incId_.GetHashCode();
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011BBE RID: 72638 RVA: 0x0029870B File Offset: 0x0029690B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011BBF RID: 72639 RVA: 0x00298718 File Offset: 0x00296918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011BC0 RID: 72640 RVA: 0x00298724 File Offset: 0x00296924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.incId_.WriteTo(ref output, PhantomEquipGroupInfo._repeated_incId_codec);
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011BC1 RID: 72641 RVA: 0x00298778 File Offset: 0x00296978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.incId_.CalculateSize(PhantomEquipGroupInfo._repeated_incId_codec);
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011BC2 RID: 72642 RVA: 0x002987D0 File Offset: 0x002969D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomEquipGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.incId_.Add(other.incId_);
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011BC3 RID: 72643 RVA: 0x00298822 File Offset: 0x00296A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011BC4 RID: 72644 RVA: 0x0029882C File Offset: 0x00296A2C
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
				if (num != 8U && num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.incId_.AddEntriesFrom(ref input, PhantomEquipGroupInfo._repeated_incId_codec);
				}
			}
		}

		// Token: 0x04006F76 RID: 28534
		private static readonly MessageParser<PhantomEquipGroupInfo> _parser = new MessageParser<PhantomEquipGroupInfo>(() => new PhantomEquipGroupInfo());

		// Token: 0x04006F77 RID: 28535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F78 RID: 28536
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006F79 RID: 28537
		private static readonly FieldCodec<int> _repeated_incId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006F7A RID: 28538
		private readonly RepeatedField<int> incId_ = new RepeatedField<int>();

		// Token: 0x04006F7B RID: 28539
		public const int NameFieldNumber = 2;

		// Token: 0x04006F7C RID: 28540
		private string name_ = "";
	}
}
