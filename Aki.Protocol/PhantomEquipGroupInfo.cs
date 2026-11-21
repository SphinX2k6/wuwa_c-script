using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBB RID: 3259
	public sealed class PhantomEquipGroupInfo : IMessage<PhantomEquipGroupInfo>, IMessage, IEquatable<PhantomEquipGroupInfo>, IDeepCloneable<PhantomEquipGroupInfo>, IBufferMessage
	{
		// Token: 0x06011AB1 RID: 72369 RVA: 0x00296861 File Offset: 0x00294A61
		[NullableContext(1)]
		public static PhantomEquipGroupInfo Create()
		{
			return new PhantomEquipGroupInfo();
		}

		// Token: 0x17003A88 RID: 14984
		// (get) Token: 0x06011AB2 RID: 72370 RVA: 0x00296868 File Offset: 0x00294A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomEquipGroupInfo> Parser
		{
			get
			{
				return PhantomEquipGroupInfo._parser;
			}
		}

		// Token: 0x17003A89 RID: 14985
		// (get) Token: 0x06011AB3 RID: 72371 RVA: 0x0029686F File Offset: 0x00294A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x06011AB4 RID: 72372 RVA: 0x00296872 File Offset: 0x00294A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfo.Descriptor;
			}
		}

		// Token: 0x06011AB5 RID: 72373 RVA: 0x00296879 File Offset: 0x00294A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfo()
		{
		}

		// Token: 0x06011AB6 RID: 72374 RVA: 0x00296897 File Offset: 0x00294A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfo(PhantomEquipGroupInfo other) : this()
		{
			this.incId_ = other.incId_.Clone();
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011AB7 RID: 72375 RVA: 0x002968CD File Offset: 0x00294ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfo Clone()
		{
			return new PhantomEquipGroupInfo(this);
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x06011AB8 RID: 72376 RVA: 0x002968D5 File Offset: 0x00294AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> IncId
		{
			get
			{
				return this.incId_;
			}
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x06011AB9 RID: 72377 RVA: 0x002968DD File Offset: 0x00294ADD
		// (set) Token: 0x06011ABA RID: 72378 RVA: 0x002968E5 File Offset: 0x00294AE5
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

		// Token: 0x06011ABB RID: 72379 RVA: 0x002968F8 File Offset: 0x00294AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfo);
		}

		// Token: 0x06011ABC RID: 72380 RVA: 0x00296908 File Offset: 0x00294B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfo other)
		{
			return other != null && (other == this || (this.incId_.Equals(other.incId_) && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011ABD RID: 72381 RVA: 0x0029695C File Offset: 0x00294B5C
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

		// Token: 0x06011ABE RID: 72382 RVA: 0x002969AB File Offset: 0x00294BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011ABF RID: 72383 RVA: 0x002969B8 File Offset: 0x00294BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AC0 RID: 72384 RVA: 0x002969C4 File Offset: 0x00294BC4
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

		// Token: 0x06011AC1 RID: 72385 RVA: 0x00296A18 File Offset: 0x00294C18
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

		// Token: 0x06011AC2 RID: 72386 RVA: 0x00296A70 File Offset: 0x00294C70
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

		// Token: 0x06011AC3 RID: 72387 RVA: 0x00296AC2 File Offset: 0x00294CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AC4 RID: 72388 RVA: 0x00296ACC File Offset: 0x00294CCC
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

		// Token: 0x04006F8A RID: 28554
		private static readonly MessageParser<PhantomEquipGroupInfo> _parser = new MessageParser<PhantomEquipGroupInfo>(() => new PhantomEquipGroupInfo());

		// Token: 0x04006F8B RID: 28555
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F8C RID: 28556
		public const int IncIdFieldNumber = 1;

		// Token: 0x04006F8D RID: 28557
		private static readonly FieldCodec<int> _repeated_incId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006F8E RID: 28558
		private readonly RepeatedField<int> incId_ = new RepeatedField<int>();

		// Token: 0x04006F8F RID: 28559
		public const int NameFieldNumber = 2;

		// Token: 0x04006F90 RID: 28560
		private string name_ = "";
	}
}
