using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D09 RID: 3337
	[NetMessage(EMessageId.PhBaPlanFindPlanRequest)]
	public sealed class PhBaPlanFindPlanRequest : IMessage<PhBaPlanFindPlanRequest>, IMessage, IEquatable<PhBaPlanFindPlanRequest>, IDeepCloneable<PhBaPlanFindPlanRequest>, IBufferMessage
	{
		// Token: 0x060120D1 RID: 73937 RVA: 0x002A3AF1 File Offset: 0x002A1CF1
		[NullableContext(1)]
		public static PhBaPlanFindPlanRequest Create()
		{
			return new PhBaPlanFindPlanRequest();
		}

		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x060120D2 RID: 73938 RVA: 0x002A3AF8 File Offset: 0x002A1CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x060120D3 RID: 73939 RVA: 0x002A3AFB File Offset: 0x002A1CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanFindPlanRequest.Descriptor;
			}
		}

		// Token: 0x060120D4 RID: 73940 RVA: 0x002A3B02 File Offset: 0x002A1D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanRequest()
		{
		}

		// Token: 0x060120D5 RID: 73941 RVA: 0x002A3B15 File Offset: 0x002A1D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanRequest(PhBaPlanFindPlanRequest other) : this()
		{
			this.targetCode_ = other.targetCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120D6 RID: 73942 RVA: 0x002A3B3A File Offset: 0x002A1D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanFindPlanRequest Clone()
		{
			return new PhBaPlanFindPlanRequest(this);
		}

		// Token: 0x17003BD1 RID: 15313
		// (get) Token: 0x060120D7 RID: 73943 RVA: 0x002A3B42 File Offset: 0x002A1D42
		// (set) Token: 0x060120D8 RID: 73944 RVA: 0x002A3B4A File Offset: 0x002A1D4A
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

		// Token: 0x060120D9 RID: 73945 RVA: 0x002A3B5D File Offset: 0x002A1D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanFindPlanRequest);
		}

		// Token: 0x060120DA RID: 73946 RVA: 0x002A3B6B File Offset: 0x002A1D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanFindPlanRequest other)
		{
			return other != null && (other == this || (!(this.TargetCode != other.TargetCode) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120DB RID: 73947 RVA: 0x002A3BA0 File Offset: 0x002A1DA0
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

		// Token: 0x060120DC RID: 73948 RVA: 0x002A3BE1 File Offset: 0x002A1DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120DD RID: 73949 RVA: 0x002A3BEE File Offset: 0x002A1DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120DE RID: 73950 RVA: 0x002A3BF7 File Offset: 0x002A1DF7
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

		// Token: 0x060120DF RID: 73951 RVA: 0x002A3C30 File Offset: 0x002A1E30
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

		// Token: 0x060120E0 RID: 73952 RVA: 0x002A3C73 File Offset: 0x002A1E73
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

		// Token: 0x060120E1 RID: 73953 RVA: 0x002A3CA9 File Offset: 0x002A1EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120E2 RID: 73954 RVA: 0x002A3CB4 File Offset: 0x002A1EB4
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

		// Token: 0x0400715C RID: 29020
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400715D RID: 29021
		public const int TargetCodeFieldNumber = 2;

		// Token: 0x0400715E RID: 29022
		private string targetCode_ = "";
	}
}
