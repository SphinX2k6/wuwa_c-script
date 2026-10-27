using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CC RID: 4300
	[NetMessage(EMessageId.RoleTrialSceneRollbackPush)]
	public sealed class RoleTrialSceneRollbackPush : IMessage<RoleTrialSceneRollbackPush>, IMessage, IEquatable<RoleTrialSceneRollbackPush>, IDeepCloneable<RoleTrialSceneRollbackPush>, IBufferMessage
	{
		// Token: 0x06016F1C RID: 93980 RVA: 0x00354C35 File Offset: 0x00352E35
		[NullableContext(1)]
		public static RoleTrialSceneRollbackPush Create()
		{
			return new RoleTrialSceneRollbackPush();
		}

		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x06016F1D RID: 93981 RVA: 0x00354C3C File Offset: 0x00352E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x06016F1E RID: 93982 RVA: 0x00354C3F File Offset: 0x00352E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialSceneRollbackPush.Descriptor;
			}
		}

		// Token: 0x06016F1F RID: 93983 RVA: 0x00354C46 File Offset: 0x00352E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSceneRollbackPush()
		{
		}

		// Token: 0x06016F20 RID: 93984 RVA: 0x00354C4E File Offset: 0x00352E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSceneRollbackPush(RoleTrialSceneRollbackPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F21 RID: 93985 RVA: 0x00354C67 File Offset: 0x00352E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialSceneRollbackPush Clone()
		{
			return new RoleTrialSceneRollbackPush(this);
		}

		// Token: 0x06016F22 RID: 93986 RVA: 0x00354C6F File Offset: 0x00352E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialSceneRollbackPush);
		}

		// Token: 0x06016F23 RID: 93987 RVA: 0x00354C7D File Offset: 0x00352E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialSceneRollbackPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016F24 RID: 93988 RVA: 0x00354C9C File Offset: 0x00352E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016F25 RID: 93989 RVA: 0x00354CC2 File Offset: 0x00352EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F26 RID: 93990 RVA: 0x00354CCF File Offset: 0x00352ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F27 RID: 93991 RVA: 0x00354CD8 File Offset: 0x00352ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F28 RID: 93992 RVA: 0x00354CF0 File Offset: 0x00352EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016F29 RID: 93993 RVA: 0x00354D16 File Offset: 0x00352F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialSceneRollbackPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016F2A RID: 93994 RVA: 0x00354D33 File Offset: 0x00352F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F2B RID: 93995 RVA: 0x00354D3C File Offset: 0x00352F3C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040088B7 RID: 34999
		private UnknownFieldSet _unknownFields;
	}
}
