using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0D RID: 3341
	[NetMessage(EMessageId.PhBaPlanSetFiveStarSwitchRequest)]
	public sealed class PhBaPlanSetFiveStarSwitchRequest : IMessage<PhBaPlanSetFiveStarSwitchRequest>, IMessage, IEquatable<PhBaPlanSetFiveStarSwitchRequest>, IDeepCloneable<PhBaPlanSetFiveStarSwitchRequest>, IBufferMessage
	{
		// Token: 0x06012121 RID: 74017 RVA: 0x002A4612 File Offset: 0x002A2812
		[NullableContext(1)]
		public static PhBaPlanSetFiveStarSwitchRequest Create()
		{
			return new PhBaPlanSetFiveStarSwitchRequest();
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x06012122 RID: 74018 RVA: 0x002A4619 File Offset: 0x002A2819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x06012123 RID: 74019 RVA: 0x002A461C File Offset: 0x002A281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhBaPlanSetFiveStarSwitchRequest.Descriptor;
			}
		}

		// Token: 0x06012124 RID: 74020 RVA: 0x002A4623 File Offset: 0x002A2823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchRequest()
		{
		}

		// Token: 0x06012125 RID: 74021 RVA: 0x002A462B File Offset: 0x002A282B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchRequest(PhBaPlanSetFiveStarSwitchRequest other) : this()
		{
			this.open_ = other.open_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012126 RID: 74022 RVA: 0x002A4650 File Offset: 0x002A2850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhBaPlanSetFiveStarSwitchRequest Clone()
		{
			return new PhBaPlanSetFiveStarSwitchRequest(this);
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x06012127 RID: 74023 RVA: 0x002A4658 File Offset: 0x002A2858
		// (set) Token: 0x06012128 RID: 74024 RVA: 0x002A4660 File Offset: 0x002A2860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Open
		{
			get
			{
				return this.open_;
			}
			set
			{
				this.open_ = value;
			}
		}

		// Token: 0x06012129 RID: 74025 RVA: 0x002A4669 File Offset: 0x002A2869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhBaPlanSetFiveStarSwitchRequest);
		}

		// Token: 0x0601212A RID: 74026 RVA: 0x002A4677 File Offset: 0x002A2877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhBaPlanSetFiveStarSwitchRequest other)
		{
			return other != null && (other == this || (this.Open == other.Open && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601212B RID: 74027 RVA: 0x002A46A8 File Offset: 0x002A28A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Open)
			{
				num ^= this.Open.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601212C RID: 74028 RVA: 0x002A46E7 File Offset: 0x002A28E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601212D RID: 74029 RVA: 0x002A46F4 File Offset: 0x002A28F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601212E RID: 74030 RVA: 0x002A46FD File Offset: 0x002A28FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Open)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Open);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601212F RID: 74031 RVA: 0x002A4730 File Offset: 0x002A2930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Open)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012130 RID: 74032 RVA: 0x002A4762 File Offset: 0x002A2962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhBaPlanSetFiveStarSwitchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Open)
			{
				this.Open = other.Open;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012131 RID: 74033 RVA: 0x002A4793 File Offset: 0x002A2993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012132 RID: 74034 RVA: 0x002A479C File Offset: 0x002A299C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Open = input.ReadBool();
				}
			}
		}

		// Token: 0x04007170 RID: 29040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007171 RID: 29041
		public const int OpenFieldNumber = 7;

		// Token: 0x04007172 RID: 29042
		private bool open_;
	}
}
