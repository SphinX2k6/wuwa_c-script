using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AEC RID: 2796
	[NetMessage(EMessageId.MutiplayerTeamRefreshNearListRequest)]
	public sealed class MutiplayerTeamRefreshNearListRequest : IMessage<MutiplayerTeamRefreshNearListRequest>, IMessage, IEquatable<MutiplayerTeamRefreshNearListRequest>, IDeepCloneable<MutiplayerTeamRefreshNearListRequest>, IBufferMessage
	{
		// Token: 0x0600F326 RID: 62246 RVA: 0x00237EDC File Offset: 0x002360DC
		[NullableContext(1)]
		public static MutiplayerTeamRefreshNearListRequest Create()
		{
			return new MutiplayerTeamRefreshNearListRequest();
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600F327 RID: 62247 RVA: 0x00237EE3 File Offset: 0x002360E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600F328 RID: 62248 RVA: 0x00237EE6 File Offset: 0x002360E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MutiplayerTeamRefreshNearListRequest.Descriptor;
			}
		}

		// Token: 0x0600F329 RID: 62249 RVA: 0x00237EED File Offset: 0x002360ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListRequest()
		{
		}

		// Token: 0x0600F32A RID: 62250 RVA: 0x00237EF5 File Offset: 0x002360F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListRequest(MutiplayerTeamRefreshNearListRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F32B RID: 62251 RVA: 0x00237F0E File Offset: 0x0023610E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MutiplayerTeamRefreshNearListRequest Clone()
		{
			return new MutiplayerTeamRefreshNearListRequest(this);
		}

		// Token: 0x0600F32C RID: 62252 RVA: 0x00237F16 File Offset: 0x00236116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MutiplayerTeamRefreshNearListRequest);
		}

		// Token: 0x0600F32D RID: 62253 RVA: 0x00237F24 File Offset: 0x00236124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MutiplayerTeamRefreshNearListRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F32E RID: 62254 RVA: 0x00237F44 File Offset: 0x00236144
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

		// Token: 0x0600F32F RID: 62255 RVA: 0x00237F6A File Offset: 0x0023616A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F330 RID: 62256 RVA: 0x00237F77 File Offset: 0x00236177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F331 RID: 62257 RVA: 0x00237F80 File Offset: 0x00236180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F332 RID: 62258 RVA: 0x00237F98 File Offset: 0x00236198
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

		// Token: 0x0600F333 RID: 62259 RVA: 0x00237FBE File Offset: 0x002361BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MutiplayerTeamRefreshNearListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F334 RID: 62260 RVA: 0x00237FDB File Offset: 0x002361DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F335 RID: 62261 RVA: 0x00237FE4 File Offset: 0x002361E4
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

		// Token: 0x04006209 RID: 25097
		private UnknownFieldSet _unknownFields;
	}
}
