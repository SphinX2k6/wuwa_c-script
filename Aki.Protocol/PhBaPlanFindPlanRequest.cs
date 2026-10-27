using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D19 RID: 3353
	[NetMessage(EMessageId.PhBaPlanFindPlanRequest)]
	public sealed class PhBaPlanFindPlanRequest : IMessage<PhBaPlanFindPlanRequest>, IMessage, IEquatable<PhBaPlanFindPlanRequest>, IDeepCloneable<PhBaPlanFindPlanRequest>, IBufferMessage
	{
		// Token: 0x060121CD RID: 74189 RVA: 0x002A5715 File Offset: 0x002A3915
		[NullableContext(1)]
		public static PhBaPlanFindPlanRequest Create()
		{
			return new PhBaPlanFindPlanRequest();
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x060121CE RID: 74190 RVA: 0x002A571C File Offset: 0x002A391C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x060121CF RID: 74191 RVA: 0x002A571F File Offset: 0x002A391F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanFindPlanRequest.Descriptor;
			}
		}

		// Token: 0x060121D0 RID: 74192 RVA: 0x002A5726 File Offset: 0x002A3926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanRequest()
		{
		}

		// Token: 0x060121D1 RID: 74193 RVA: 0x002A5739 File Offset: 0x002A3939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanRequest(PhBaPlanFindPlanRequest other) : this()
		{
			this.targetCode_ = other.targetCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060121D2 RID: 74194 RVA: 0x002A575E File Offset: 0x002A395E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanRequest Clone()
		{
			return new PhBaPlanFindPlanRequest(this);
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x060121D3 RID: 74195 RVA: 0x002A5766 File Offset: 0x002A3966
		// (set) Token: 0x060121D4 RID: 74196 RVA: 0x002A576E File Offset: 0x002A396E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TargetCode
		{
			get
			{
				return this.targetCode_;
			}
			set
			{
				this.targetCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060121D5 RID: 74197 RVA: 0x002A5781 File Offset: 0x002A3981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanFindPlanRequest);
		}

		// Token: 0x060121D6 RID: 74198 RVA: 0x002A578F File Offset: 0x002A398F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanFindPlanRequest other)
		{
			return other != null && (other == this || (!(this.TargetCode != other.TargetCode) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060121D7 RID: 74199 RVA: 0x002A57C4 File Offset: 0x002A39C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetCode.Length != 0)
			{
				num ^= this.TargetCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060121D8 RID: 74200 RVA: 0x002A5805 File Offset: 0x002A3A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060121D9 RID: 74201 RVA: 0x002A5812 File Offset: 0x002A3A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060121DA RID: 74202 RVA: 0x002A581B File Offset: 0x002A3A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetCode.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.TargetCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060121DB RID: 74203 RVA: 0x002A5854 File Offset: 0x002A3A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetCode.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060121DC RID: 74204 RVA: 0x002A5897 File Offset: 0x002A3A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanFindPlanRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetCode.Length != 0)
			{
				this.TargetCode = other.TargetCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060121DD RID: 74205 RVA: 0x002A58CD File Offset: 0x002A3ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060121DE RID: 74206 RVA: 0x002A58D8 File Offset: 0x002A3AD8
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TargetCode = input.ReadString();
				}
			}
		}

		// Token: 0x04007144 RID: 28996
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007145 RID: 28997
		public const int TargetCodeFieldNumber = 2;

		// Token: 0x04007146 RID: 28998
		private string targetCode_ = "";
	}
}
