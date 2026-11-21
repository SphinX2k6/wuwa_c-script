using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A12 RID: 2578
	[NetMessage(EMessageId.MotorCreateRequest)]
	public sealed class MotorCreateRequest : IMessage<MotorCreateRequest>, IMessage, IEquatable<MotorCreateRequest>, IDeepCloneable<MotorCreateRequest>, IBufferMessage
	{
		// Token: 0x0600E1CA RID: 57802 RVA: 0x00211741 File Offset: 0x0020F941
		[NullableContext(1)]
		public static MotorCreateRequest Create()
		{
			return new MotorCreateRequest();
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0600E1CB RID: 57803 RVA: 0x00211748 File Offset: 0x0020F948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0600E1CC RID: 57804 RVA: 0x0021174B File Offset: 0x0020F94B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorCreateRequest.Descriptor;
			}
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x00211752 File Offset: 0x0020F952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateRequest()
		{
		}

		// Token: 0x0600E1CE RID: 57806 RVA: 0x0021175A File Offset: 0x0020F95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateRequest(MotorCreateRequest other) : this()
		{
			this.isCreate_ = other.isCreate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1CF RID: 57807 RVA: 0x0021177F File Offset: 0x0020F97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorCreateRequest Clone()
		{
			return new MotorCreateRequest(this);
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0600E1D0 RID: 57808 RVA: 0x00211787 File Offset: 0x0020F987
		// (set) Token: 0x0600E1D1 RID: 57809 RVA: 0x0021178F File Offset: 0x0020F98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCreate
		{
			get
			{
				return this.isCreate_;
			}
			set
			{
				this.isCreate_ = value;
			}
		}

		// Token: 0x0600E1D2 RID: 57810 RVA: 0x00211798 File Offset: 0x0020F998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorCreateRequest);
		}

		// Token: 0x0600E1D3 RID: 57811 RVA: 0x002117A6 File Offset: 0x0020F9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorCreateRequest other)
		{
			return other != null && (other == this || (this.IsCreate == other.IsCreate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x002117D4 File Offset: 0x0020F9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsCreate)
			{
				num ^= this.IsCreate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00211813 File Offset: 0x0020FA13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x00211820 File Offset: 0x0020FA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x00211829 File Offset: 0x0020FA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCreate)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsCreate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x0021185C File Offset: 0x0020FA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsCreate)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1D9 RID: 57817 RVA: 0x0021188E File Offset: 0x0020FA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorCreateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsCreate)
			{
				this.IsCreate = other.IsCreate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1DA RID: 57818 RVA: 0x002118BF File Offset: 0x0020FABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1DB RID: 57819 RVA: 0x002118C8 File Offset: 0x0020FAC8
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsCreate = input.ReadBool();
				}
			}
		}

		// Token: 0x04005D22 RID: 23842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D23 RID: 23843
		public const int IsCreateFieldNumber = 12;

		// Token: 0x04005D24 RID: 23844
		private bool isCreate_;
	}
}
