using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001421 RID: 5153
	[NetMessage(EMessageId.TrapDefenseDevelopResetRequest)]
	public sealed class TrapDefenseDevelopResetRequest : IMessage<TrapDefenseDevelopResetRequest>, IMessage, IEquatable<TrapDefenseDevelopResetRequest>, IDeepCloneable<TrapDefenseDevelopResetRequest>, IBufferMessage
	{
		// Token: 0x0601B4FB RID: 111867 RVA: 0x003F516E File Offset: 0x003F336E
		[NullableContext(1)]
		public static TrapDefenseDevelopResetRequest Create()
		{
			return new TrapDefenseDevelopResetRequest();
		}

		// Token: 0x17005C20 RID: 23584
		// (get) Token: 0x0601B4FC RID: 111868 RVA: 0x003F5175 File Offset: 0x003F3375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C21 RID: 23585
		// (get) Token: 0x0601B4FD RID: 111869 RVA: 0x003F5178 File Offset: 0x003F3378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseDevelopResetRequest.Descriptor;
			}
		}

		// Token: 0x0601B4FE RID: 111870 RVA: 0x003F517F File Offset: 0x003F337F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetRequest()
		{
		}

		// Token: 0x0601B4FF RID: 111871 RVA: 0x003F5187 File Offset: 0x003F3387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetRequest(TrapDefenseDevelopResetRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B500 RID: 111872 RVA: 0x003F51AC File Offset: 0x003F33AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseDevelopResetRequest Clone()
		{
			return new TrapDefenseDevelopResetRequest(this);
		}

		// Token: 0x17005C22 RID: 23586
		// (get) Token: 0x0601B501 RID: 111873 RVA: 0x003F51B4 File Offset: 0x003F33B4
		// (set) Token: 0x0601B502 RID: 111874 RVA: 0x003F51BC File Offset: 0x003F33BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0601B503 RID: 111875 RVA: 0x003F51C5 File Offset: 0x003F33C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseDevelopResetRequest);
		}

		// Token: 0x0601B504 RID: 111876 RVA: 0x003F51D3 File Offset: 0x003F33D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseDevelopResetRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B505 RID: 111877 RVA: 0x003F5204 File Offset: 0x003F3404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B506 RID: 111878 RVA: 0x003F5243 File Offset: 0x003F3443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B507 RID: 111879 RVA: 0x003F5250 File Offset: 0x003F3450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B508 RID: 111880 RVA: 0x003F5259 File Offset: 0x003F3459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B509 RID: 111881 RVA: 0x003F528C File Offset: 0x003F348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B50A RID: 111882 RVA: 0x003F52CA File Offset: 0x003F34CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseDevelopResetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B50B RID: 111883 RVA: 0x003F52FB File Offset: 0x003F34FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B50C RID: 111884 RVA: 0x003F5304 File Offset: 0x003F3504
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009DDA RID: 40410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DDB RID: 40411
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04009DDC RID: 40412
		private int activityId_;
	}
}
