using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061E RID: 1566
	[NetMessage(EMessageId.FormationSwitchCurrentRequest)]
	public sealed class FormationSwitchCurrentRequest : IMessage<FormationSwitchCurrentRequest>, IMessage, IEquatable<FormationSwitchCurrentRequest>, IDeepCloneable<FormationSwitchCurrentRequest>, IBufferMessage
	{
		// Token: 0x060090E2 RID: 37090 RVA: 0x0015F33A File Offset: 0x0015D53A
		[NullableContext(1)]
		public static FormationSwitchCurrentRequest Create()
		{
			return new FormationSwitchCurrentRequest();
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x060090E3 RID: 37091 RVA: 0x0015F341 File Offset: 0x0015D541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x060090E4 RID: 37092 RVA: 0x0015F344 File Offset: 0x0015D544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchCurrentRequest.Descriptor;
			}
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x0015F34B File Offset: 0x0015D54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentRequest()
		{
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x0015F353 File Offset: 0x0015D553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentRequest(FormationSwitchCurrentRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x0015F378 File Offset: 0x0015D578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentRequest Clone()
		{
			return new FormationSwitchCurrentRequest(this);
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x060090E8 RID: 37096 RVA: 0x0015F380 File Offset: 0x0015D580
		// (set) Token: 0x060090E9 RID: 37097 RVA: 0x0015F388 File Offset: 0x0015D588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060090EA RID: 37098 RVA: 0x0015F391 File Offset: 0x0015D591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchCurrentRequest);
		}

		// Token: 0x060090EB RID: 37099 RVA: 0x0015F39F File Offset: 0x0015D59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchCurrentRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090EC RID: 37100 RVA: 0x0015F3D0 File Offset: 0x0015D5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x0015F40F File Offset: 0x0015D60F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090EE RID: 37102 RVA: 0x0015F41C File Offset: 0x0015D61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090EF RID: 37103 RVA: 0x0015F425 File Offset: 0x0015D625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090F0 RID: 37104 RVA: 0x0015F458 File Offset: 0x0015D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x0015F496 File Offset: 0x0015D696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchCurrentRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x0015F4C7 File Offset: 0x0015D6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x0015F4D0 File Offset: 0x0015D6D0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004683 RID: 18051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004684 RID: 18052
		public const int IdFieldNumber = 14;

		// Token: 0x04004685 RID: 18053
		private int id_;
	}
}
